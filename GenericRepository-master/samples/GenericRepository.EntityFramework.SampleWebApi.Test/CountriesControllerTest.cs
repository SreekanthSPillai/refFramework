﻿using AutoMapper;
using GenericRepository.EntityFramework.SampleCore.Entities;
using GenericRepository.EntityFramework.SampleWebApi.Controllers;
using GenericRepository.EntityFramework.SampleWebApi.Test.Infrastructure;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace GenericRepository.EntityFramework.SampleWebApi.Test {
    
    public class CountriesControllerTest {

        public CountriesControllerTest() {

            Global.RegisterMappings();
        }

        [Fact]
        public void GetCountries_Should_Get_Expected_Result() { 
            
            // Arrange

            var countries = new List<Country>() { 
                new Country { Id = 1, Name = "Turkey", ISOCode = "TR", CreatedOn = DateTimeOffset.Now },
                new Country { Id = 2, Name = "United Kingdom", ISOCode = "EN", CreatedOn = DateTimeOffset.Now },
                new Country { Id = 3, Name = "United States", ISOCode = "US", CreatedOn = DateTimeOffset.Now },
                new Country { Id = 4, Name = "Argentina", ISOCode = "AR", CreatedOn = DateTimeOffset.Now },
                new Country { Id = 4, Name = "Bahamas", ISOCode = "BS", CreatedOn = DateTimeOffset.Now },
                new Country { Id = 4, Name = "Uruguay", ISOCode = "UY", CreatedOn = DateTimeOffset.Now }
            };
            var dbSet = new FakeDbSet<Country>();
            foreach (var country in countries) {
                dbSet.Add(country);
            }

            var entitiesContext = new Mock<IEntitiesContext>();
            entitiesContext.Setup(ec => ec.Set<Country>()).Returns(dbSet);
            var countriesRepo = new EntityRepository<Country>(entitiesContext.Object);
            var countriesController = new CountriesController(countriesRepo, Mapper.Engine);
            var pageIndex = 1;
            var pageSize = 3;

            // Act
            var paginatedDto = countriesController.GetCountries(pageIndex, pageSize);

            // Assert
            Assert.NotNull(paginatedDto);
            Assert.Equal(countries.Count, paginatedDto.TotalCount);
            Assert.Equal(pageSize, paginatedDto.PageSize);
            Assert.Equal(pageIndex, paginatedDto.PageIndex);
        }
    }
}