﻿using MockingUnitTestsDemoApp.Impl.Models;
using MockingUnitTestsDemoApp.Impl.Repositories.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MockingUnitTestsDemoApp.Tests.Mocks.Repositories
{
    public class MockTeamRepository : Mock<ITeamRepository>
    {
        public MockTeamRepository MockGetByID(Team result)
        {
            Setup(x => x.GetByID(It.IsAny<int>()))
                .ReturnsAsync(result);

            return this;
        }

        public MockTeamRepository MockGetForLeague(List<Team> results)
        {
            Setup(x => x.GetForLeague(It.IsAny<int>()))
                .ReturnsAsync(results);

            return this;
        }

        public MockTeamRepository VerifyGetForLeague(Times times)
        {
            Verify(x => x.GetForLeague(It.IsAny<int>()), times);

            return this;
        }
    }
}