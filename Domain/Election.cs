using System.Collections.Generic;
using System.Linq;
using System;

namespace Domain
{
    public class Election
    {
        private List<Candidate> candidates {get; set;}

        public IReadOnlyCollection<Candidate> Candidates => candidates;
        
        public Election()
        {
            candidates = new List<Candidate>();
        }
        
        public bool TryCreateCandidates(List<Candidate> candidatesInput, string password)
        {
            if (password == "Pa$$w0rd")
            {
                if (candidatesInput == null)
                {
                    return true;
                }
                candidates.AddRange(candidatesInput);
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
                var mostVotes = candidates.Max(candidate => candidate.Votes);
                foreach (var candidate in candidates)
                {
                    if (candidate.Votes == mostVotes)
                    {
                        winners.Add(candidate);
                    }
                }
            }

            return winners;
        } 
    }
}