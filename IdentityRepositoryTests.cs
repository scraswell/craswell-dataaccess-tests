using NUnit.Framework;
using System;

using Craswell.DataAccess;
using Craswell.Models.IdentityManagement;

namespace Craswell.Encryption.UnitTests
{
    [TestFixture()]
    public class IdentityRepositoryTests
    {
        [Test()]
        public void IdentityRepositoryTests_CanPersistIdentity()
        {
            var connectionString = @"Data Source=.\IdentityRepositoryTests.db;Version=3;";

            var persistenceLayer = new PersistenceLayer(
                connectionString,
                DatabaseType.SQLite);

            var identityRepository = new IdentityRepository(
                "test passphrase.",
                persistenceLayer);

            ////var identity = new Identity()
            ////{
            ////    AssociatedResource = "http://testsite.com/testsite/login",
            ////    Description = "Test identity",
            ////    Notes = "Test notes",
            ////    Password = "Test password",
            ////    Title = "Test title",
            ////    Username = "Test username"
            ////};

            ////identityRepository.Create(identity);

            var identity = identityRepository.Read(1);

        }
    }
}

