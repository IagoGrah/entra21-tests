using Xunit;
using System.Collections.Generic;
using System.Linq;
using Domain;
using System;

namespace Tests
{
    public class CandidateTest
    {
        [Fact]
        public void should_create_candidate()
        {
            var candidate = new Candidate("Jonathan", "123.345.456-32");

            Assert.Equal("Jonathan", candidate.Name);
            Assert.Equal("123.345.456-32", candidate.Cpf);
            Assert.Equal(0, candidate.Votes);
            Assert.NotEqual(Guid.Empty, candidate.Id);
        }

        [Fact]
        public void should_vote_once()
        {
            var candidate = new Candidate("Jonathan", "123.345.456-32");
            
            candidate.Vote();

            Assert.Equal(1, candidate.Votes);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("i23.a56.t89-io")]
        [InlineData("123.456.789-10")]
        [InlineData("000.000.000-00")]
        [InlineData("814.460.920-461")]
        [InlineData("8144092046")]
        [InlineData("14 46 09 20 64")]
        public void should_return_false_when_invalid_cpf(string cpf)
        {
            var candidate = new Candidate("Jonathan", cpf);

            var isValid = candidate.ValidateCPF();

            Assert.False(isValid);
        }

        [Theory]
        [InlineData("814.460.920-46")]
        [InlineData("81446092046")]
        [InlineData("814.....460....920----46")]
        [InlineData("814 460 920 46")]
        public void should_return_true_when_valid_cpf(string cpf)
        {
            var candidate = new Candidate("Jonathan", cpf);

            var isValid = candidate.ValidateCPF();

            Assert.True(isValid);
        }

        [Theory]
        [InlineData("J0n47h4n")]
        [InlineData("Jo   nathan")]
        [InlineData("Jonathan     ")]
        [InlineData("  Jonathan")]
        [InlineData("J%#!(#*n")]
        [InlineData("!4@!")]
        [InlineData("")]
        [InlineData(null)]
        public void should_return_false_when_invalid_name(string name)
        {
            var candidate = new Candidate(name, "814.460.920-46");

            var isValid = candidate.ValidateName();

            Assert.False(isValid);
        }

        [Theory]
        [InlineData("Jonathan")]
        [InlineData("JONATHAN")]
        [InlineData("jonathan")]
        [InlineData("j")]
        public void should_return_true_when_valid_name(string name)
        {
            var candidate = new Candidate(name, "814.460.920-46");

            var isValid = candidate.ValidateName();

            Assert.True(isValid);
        }
    }
}