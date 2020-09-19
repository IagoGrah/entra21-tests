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
            var candidatesInput = new List<(int id, string name)>{(1, "Jonas")};

            bool result = election.TryCreateCandidates(candidatesInput, "WrongPassword123");

            Assert.False(result);
        }
        
        [Fact]
        public void should_return_true_when_correct_password()
        {
            var election = new Election();
            var candidatesInput = new List<(int id, string name)>{(1, "Jonas")};

            bool result = election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            Assert.True(result);
        }

        [Fact]
        public void should_return_menu_with_candidates()
        {
            var election = new Election();
            var candidatesInput = new List<(int id, string name)>{(1, "Jonas"), (2, "Ramos")};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            var result = election.ShowMenu();

            Assert.Equal(new List<string>{"Vote 1 para Jonas", "Vote 2 para Ramos"}, result);
        }

        [Fact]
        public void should_return_2_and_0_votes()
        {
            var election = new Election();
            (int id, string name) jonas = (1, "Jonas");
            (int id, string name) ramos = (2, "Ramos");
            var candidatesInput = new List<(int id, string name)>{jonas, ramos};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");

            election.Vote(jonas.id);
            election.Vote(jonas.id);

            var candidateJonas = election.Candidates.Find(x => x.id == jonas.id);
            var candidateRamos = election.Candidates.Find(x => x.id == ramos.id);
            Assert.Equal(2, candidateJonas.votes);
            Assert.Equal(0, candidateRamos.votes);
        }

        [Fact]
        public void should_return_0_null_0_when_wrong_password()
        {
            var election = new Election();
            (int id, string name) jonas = (1, "Jonas");
            (int id, string name) ramos = (2, "Ramos");
            var candidatesInput = new List<(int id, string name)>{jonas, ramos};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");
            election.Vote(jonas.id);

            var winner = election.Poll("WrongPassword123");

            Assert.Equal((0, null, 0), winner);
        }

        [Fact]
        public void should_return_jonas_winner()
        {
            var election = new Election();
            (int id, string name) jonas = (1, "Jonas");
            (int id, string name) ramos = (2, "Ramos");
            var candidatesInput = new List<(int id, string name)>{jonas, ramos};
            election.TryCreateCandidates(candidatesInput, "Pa$$w0rd");
            election.Vote(jonas.id);
            election.Vote(jonas.id);

            var winner = election.Poll("Pa$$w0rd");

            var candidateJonas = election.Candidates.Find(x => x.id == jonas.id);
            Assert.Equal(candidateJonas, winner);
        }
    }
}