using Xunit;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Tests
{
    public class ElectionTest
    {
        public List<Candidate> GetMockCandidates(int amount)
        {
            var MockCandidates = new List<Candidate>
            {
                new Candidate("Jonas", "814.460.920-46"),
                new Candidate("Ramos", "479.066.260-87"),
                new Candidate("Bezos", "481.529.140-37"),
                new Candidate("Jesus", "047.126.800-32")
            };

            return MockCandidates.Take(amount).ToList();
        }
        
        [Fact]
        public void should_return_false_when_wrong_password()
        {
            var election = new Election();
            var candidatesInput = GetMockCandidates(1);

            bool result = election.TryCreateCandidates(candidatesInput, "WrongPassword123");

            Assert.False(result);
            Assert.Empty(election.Candidates);
        }
        
        [Fact]
        public void should_return_true_when_correct_password()
        {
            var election = new Election();
            var candidatesInput = GetMockCandidates(1);

            bool result = election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            Assert.True(result);
            Assert.Equal(1, election.Candidates.Count);
        }

        [Fact]
        public void should_return_empty_if_null_input()
        {
            var election = new Election();
            List<Candidate> candidatesInput = null;

            bool result = election.TryCreateCandidates(candidatesInput, "WrongPassword123");

            Assert.False(result);
            Assert.Empty(election.Candidates);
        }

        [Fact]
        public void should_return_different_ids()
        {
            var election = new Election();
            var candidatesInput = GetMockCandidates(2);
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            var firstId = election.GetCandidateIdsByName(candidatesInput[0].Name)[0];
            var secondId = election.GetCandidateIdsByName(candidatesInput[1].Name)[0];

            Assert.NotEqual(firstId, secondId);
        }

        [Fact]
        public void should_return_2_ids()
        {
            var election = new Election();
            var jonas1 = new Candidate("Jonas", "814.460.920-46");
            var jonas2 = new Candidate("Jonas", "479.066.260-87");
            var candidatesInput = new List<Candidate>{jonas1, jonas2};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            var foundIds = election.GetCandidateIdsByName("Jonas");

            Assert.Equal(2, foundIds.Count);
        }

        [Fact]
        public void should_return_jonas1_id()
        {
            var election = new Election();
            var jonas1 = new Candidate("Jonas", "814.460.920-46");
            var jonas2 = new Candidate("Jonas", "479.066.260-87");
            var candidatesInput = new List<Candidate>{jonas1, jonas2};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            var foundId = election.GetCandidateIdByCPF(jonas1.Cpf);

            Assert.Equal(jonas1.Id, foundId);
        }

        [Fact]
        public void should_return_false_and_not_vote_when_cpf_is_invalid()
        {
            var election = new Election();
            var candidatesInput = GetMockCandidates(1);
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            var hasVoted = election.Vote("Wrong CPF");

            Assert.Equal(0, candidatesInput[0].Votes);
            Assert.False(hasVoted);
        }
        
        [Fact]
        public void should_return_2_and_0_votes()
        {
            var election = new Election();
            var candidatesInput = GetMockCandidates(2);
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            election.Vote(candidatesInput[0].Cpf);
            election.Vote(candidatesInput[0].Cpf);

            Assert.Equal(2, candidatesInput[0].Votes);
            Assert.Equal(0, candidatesInput[1].Votes);
        }
        
        [Fact]
        public void should_return_null_when_wrong_password()
        {
            var election = new Election();
            var candidatesInput = GetMockCandidates(2);
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");
            election.Vote(candidatesInput[0].Cpf);

            var winners = election.Poll("WrongPassword123");

            Assert.Null(winners[0]);
        }

        [Fact]
        public void should_return_jonas_winner()
        {
            var election = new Election();
            var candidatesInput = GetMockCandidates(2);
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");
            election.Vote(candidatesInput[0].Cpf);

            var winners = election.Poll("Pa$$w0rd");

            Assert.Equal(candidatesInput[0].Name, winners[0].Name);
        }

        [Fact]
        public void should_return_two_different_winners()
        {
            var election = new Election();
            var candidatesInput = GetMockCandidates(2);
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");
            election.Vote(candidatesInput[0].Cpf);
            election.Vote(candidatesInput[1].Cpf);

            var winners = election.Poll("Pa$$w0rd");

            Assert.Equal(2, winners.Count);
            Assert.True(candidatesInput[0].Id == winners[0].Id ^ candidatesInput[1].Id == winners[0].Id);
            Assert.True(candidatesInput[0].Id == winners[1].Id ^ candidatesInput[1].Id == winners[1].Id);
            Assert.NotEqual(winners[0].Id, winners[1].Id);
        }
    }
}