using Xunit;
using System.Collections.Generic;

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

            Assert.Equal(election.Candidates[0].id, foundId);
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

            var candidateJonas = election.Candidates.Find(x => x.id == jonasId);
            var candidateRamos = election.Candidates.Find(x => x.id == ramosId);
            Assert.Equal(2, candidateJonas.votes);
            Assert.Equal(0, candidateRamos.votes);
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

            Assert.Null(winners[0].name);
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

            Assert.Equal(jonas.name, winners[0].name);
        }
    }
}