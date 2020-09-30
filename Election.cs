using System.Collections.Generic;
using System.Linq;
using System;

namespace entra21_tests
{
    public class Election
    {
        private List<Candidate> candidates {get; set;}

        public IReadOnlyCollection<Candidate> Candidates => candidates;

        public bool TryCreateCandidates(List<(string name, string cpf)> candidatesInput, string password)
        {
            if (password == "Pa$$w0rd")
            {
                candidates = candidatesInput.Select(candidate => {return (new Candidate(candidate.name, candidate.cpf));}).ToList();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Guid GetCandidateIdByCPF(string cpf)
        {
            return candidates.Find(x => x.Cpf == cpf).Id;
        }

        public List<Guid> GetCandidateIdsByName(string name)
        {
            var foundCandidates = candidates.Where(x => x.Name == name);
            return foundCandidates.Select(x => x.Id).ToList();
        }

        public void Vote(Guid id)
        {
            var votedCandidate = candidates.Find(x => x.Id == id);
            votedCandidate.Vote();
        }

        public List<Candidate> Poll(string password)
        {
            var winners = new List<Candidate>();
            
            if (password != "Pa$$w0rd")
            {
                winners.Add(null);
            }
            else
            {
                var mostVotes = candidates.Max(candidate => candidate.GetVotes());
                foreach (var candidate in candidates)
                {
                    if (candidate.GetVotes() == mostVotes)
                    {
                        winners.Add(candidate);
                    }
                }
            }

            return winners;
        } 
    }
}
