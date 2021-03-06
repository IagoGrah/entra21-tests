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
        
        public bool CreateCandidates(List<Candidate> candidatesInput, string password)
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

        public bool Vote(string cpf)
        {
            var votedCandidate = candidates.FirstOrDefault(x => x.Cpf == cpf);
            if (votedCandidate == null)
            {
                return false;
            }
            votedCandidate.Vote();
            return true;
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
