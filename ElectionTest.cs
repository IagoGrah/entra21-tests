using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    public class ElectionTest
    {
        [Fact]
        public void should_return_false_when_wrong_password()
        {
            var election = new Election();
            var candidatesInput = new List<(string name, string cpf)>{("Jonas", "102.321.553.12")};

            bool result = election.TryCreateCandidates(candidatesInput, "WrongPassword123");

            Assert.False(result);
        }
        
        [Fact]
        public void should_return_true_when_correct_password()
        {
            var election = new Election();
            var candidatesInput = new List<(string name, string cpf)>{("Jonas", "102.321.553.12")};

            bool result = election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            Assert.True(result);
        }

        [Fact]
        public void should_return_different_ids()
        {
            var election = new Election();
            (string name, string cpf) jonas = ("Jonas", "454.273.081.54");
            (string name, string cpf) ramos = ("Ramos", "123.456.789.10");
            var candidatesInput = new List<(string name, string cpf)>{jonas, ramos};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            var jonasId = election.GetCandidateIdsByName(jonas.name)[0];
            var ramosId = election.GetCandidateIdsByName(ramos.name)[0];

            Assert.NotEqual(jonasId, ramosId);
        }

        [Fact]
        public void should_return_2_ids()
        {
            var election = new Election();
            (string name, string cpf) jonas1 = ("Jonas", "454.273.081.54");
            (string name, string cpf) jonas2 = ("Jonas", "123.456.789.10");
            var candidatesInput = new List<(string name, string cpf)>{jonas1, jonas2};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            var foundIds = election.GetCandidateIdsByName("Jonas");

            Assert.Equal(2, foundIds.Count);
        }

        [Fact]
        public void should_return_jonas_id()
        {
            var election = new Election();
            (string name, string cpf) jonas1 = ("Jonas", "454.273.081.54");
            (string name, string cpf) jonas2 = ("Jonas", "123.456.789.10");
            var candidatesInput = new List<(string name, string cpf)>{jonas1, jonas2};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            var foundId = election.GetCandidateIdByCPF(jonas1.cpf);

            Assert.Equal(election.Candidates.ElementAt(0).Id, foundId);
        }

        [Fact]
        public void should_return_2_and_0_votes()
        {
            var election = new Election();
            (string name, string cpf) jonas = ("Jonas", "454.273.081.54");
            (string name, string cpf) ramos = ("Ramos", "123.456.789.10");
            var candidatesInput = new List<(string name, string cpf)>{jonas, ramos};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");
            var jonasId = election.GetCandidateIdsByName(jonas.name)[0];
            var ramosId = election.GetCandidateIdsByName(ramos.name)[0];

            election.Vote(jonasId);
            election.Vote(jonasId);

            var candidateJonas = election.Candidates.First(x => x.Id == jonasId);
            var candidateRamos = election.Candidates.First(x => x.Id == ramosId);
            Assert.Equal(2, candidateJonas.Votes);
            Assert.Equal(0, candidateRamos.Votes);
        }
        
        [Fact]
        public void should_return_null_when_wrong_password()
        {
            var election = new Election();
            (string name, string cpf) jonas = ("Jonas", "454.273.081.54");
            (string name, string cpf) ramos = ("Ramos", "123.456.789.10");
            var candidatesInput = new List<(string name, string cpf)>{jonas, ramos};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");
            var jonasId = election.GetCandidateIdsByName(jonas.name)[0];
            var ramosId = election.GetCandidateIdsByName(ramos.name)[0];
            election.Vote(jonasId);

            var winners = election.Poll("WrongPassword123");

            Assert.Null(winners[0]);
        }

        [Fact]
        public void should_return_jonas_winner()
        {
            var election = new Election();
            (string name, string cpf) jonas = ("Jonas", "454.273.081.54");
            (string name, string cpf) ramos = ("Ramos", "123.456.789.10");
            var candidatesInput = new List<(string name, string cpf)>{jonas, ramos};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");
            var jonasId = election.GetCandidateIdsByName(jonas.name)[0];
            var ramosId = election.GetCandidateIdsByName(ramos.name)[0];
            election.Vote(jonasId);

            var winners = election.Poll("Pa$$w0rd");

            Assert.Equal(jonas.name, winners[0].Name);
        }

        [Fact]
        public void should_return_two_different_winners()
        {
            var election = new Election();
            (string name, string cpf) jonas = ("Jonas", "454.273.081.54");
            (string name, string cpf) ramos = ("Ramos", "123.456.789.10");
            var candidatesInput = new List<(string name, string cpf)>{jonas, ramos};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");
            var jonasId = election.GetCandidateIdsByName(jonas.name)[0];
            var ramosId = election.GetCandidateIdsByName(ramos.name)[0];
            election.Vote(jonasId);
            election.Vote(ramosId);

            var winners = election.Poll("Pa$$w0rd");

            Assert.Equal(2, winners.Count);
            Assert.True(jonasId == winners[0].Id ^ ramosId == winners[0].Id);
            Assert.True(jonasId == winners[1].Id ^ ramosId == winners[1].Id);
            Assert.NotEqual(winners[0].Id, winners[1].Id);
        }
    }
}