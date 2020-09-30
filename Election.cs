using System.Collections.Generic;
using System.Linq;
using System;

namespace entra21_tests
{
    public class Election
    {
        private List<(Guid id, string name, string cpf, int votes)> candidates {get; set;}

        public IReadOnlyCollection<(Guid id, string name, string cpf, int votes)> Candidates => candidates;

        public bool TryCreateCandidates(List<(string name, string cpf)> candidatesInput, string password)
        {
            if (password == "Pa$$w0rd")
            {
                candidates = candidatesInput.Select(candidate => {return (Guid.NewGuid(), candidate.name, candidate.cpf, 0);}).ToList();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Guid GetCandidateIdByCPF(string cpf)
        {
            return candidates.Find(x => x.cpf == cpf).id;
        }

        public List<Guid> GetCandidateIdsByName(string name)
        {
            var foundCandidates = candidates.Where(x => x.name == name);
            return foundCandidates.Select(x => x.id).ToList();
        }

        public void Vote(Guid id)
        {
            candidates = candidates.Select(candidate => {
                return candidate.id == id
                    ? (candidate.id, candidate.name, candidate.cpf, candidate.votes + 1)
                    : candidate; 
            }).ToList();
        }

        public List<(Guid id, string name, string cpf, int votes)> Poll(string password)
        {
            var winners = new List<(Guid id, string name, string cpf, int votes)>();
            
            if (password != "Pa$$w0rd")
            {
                winners.Add((Guid.Empty, null, null, 0));
            }
            else
            {
                var mostVotes = candidates.Max(candidate => candidate.votes);
                foreach (var candidate in candidates)
                {
                    if (candidate.votes == mostVotes)
                    {
                        winners.Add(candidate);
                    }
                }
            }

            return winners;
        } 
    }
}
