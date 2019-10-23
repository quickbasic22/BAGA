namespace BAGA.Migrations
{
    using BAGA.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BAGA.Models.BAGAContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BAGA.Models.BAGAContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Destinations.AddOrUpdate(
                new Models.Destination
                {
                    Name = "Hawaii Resort",
                    Description = "100 foot tall Hotel",
                    Country = "U.S.A",
                    Photo = new byte[1] { 1 },
                    Lodgings = new List<Lodging>
                    {
                        new Lodging { Name = "Lodging One", Owner = "Michele Bemer", IsResort = true},
                        new Lodging { Name = "Lodging Two", Owner = "Jennifer Hotely", IsResort = true}
                    }

                },
                new Models.Destination
                {
                    Name = "West Coast Paradise",
                    Description = "Mile High Paradise",
                    Country = "U.S.A",
                    Photo = new byte[1] { 1 },
                    Lodgings = new List<Lodging>
                    {
                        new Lodging { Name = "California Resorts", Owner = "Christina Porter", IsResort = true},
                        new Lodging {Name = "Baja Resorts", Owner = "Sofie Gamma", IsResort = false},
                        new Lodging {Name = "Washington State Hotel", Owner = "Carrie Eoria", IsResort = false }
                    }
                },
                new Models.Destination
                {
                    Name = "Singapore South",
                    Description = "Trip Advisor",
                    Country = "Singapore",
                    Photo = new byte[1] { 1 },
                    Lodgings = new List<Lodging>
                    {
                        new Lodging { Name = "Best Resorts", Owner = "Angelina Secy", IsResort = true},
                        new Lodging {Name = "Resort One", Owner = "Beca Moore", IsResort = true},
                        new Lodging {Name = "Hotel Paradise", Owner = "Candy Moltey", IsResort = false}
                    }
                });
            context.SaveChanges();
            context.People.AddOrUpdate(
                new Person
                {
                    FirstName = "Alex",
                    LastName = "Solzhenitsyn",
                    SocialSecurityNumber = 291822323,
                    StreetAddress = "269 Yourly St",
                    City = "Bolor",
                    ZipCode = "82825",
                    State = "NY",
                    Photo = new PersonPhoto
                    {
                        Photo = new byte[1] { 1 },
                        Caption = "Picture in Ocean"
                    }
                },
                    new Person
                    {
                        FirstName = "Keith",
                        LastName = "Harris",
                        SocialSecurityNumber = 262230525,
                        StreetAddress = "9 Owel Blvd",
                        City = "Gooder",
                        State = "Oh",
                        ZipCode = "92952",
                        Photo = new PersonPhoto
                        {
                            Photo = new byte[1] { 1 },
                            Caption = "Picture in Ocean"
                        }
                    },
                    new Person
                    {
                        FirstName = "Donna",
                        LastName = "Carreras",
                        SocialSecurityNumber = 291822323,
                        StreetAddress = "269 Yourly St",
                        City = "Bolor",
                        ZipCode = "82825",
                        State = "NY",
                        Photo = new PersonPhoto
                        {
                            Photo = new byte[1] { 0 },
                            Caption = "beach photo"
                        }
                    },
                new Person
                {
                    FirstName = "Janet",
                    LastName = "Gates",
                    SocialSecurityNumber = 262230525,
                    StreetAddress = "9 Owel Blvd",
                    City = "Gooder",
                    State = "Oh",
                    ZipCode = "92952",
                    Photo = new PersonPhoto
                    {
                        Photo = new byte[1] { 0 },
                        Caption = "Balcony Picture"
                    }
                },
                new Person
                {
                    FirstName = "Lucy",
                    LastName = "Harrington",
                    SocialSecurityNumber = 291822323,
                    StreetAddress = "269 Yourly St",
                    City = "Bolor",
                    ZipCode = "82825",
                    State = "NY",
                    Photo = new PersonPhoto
                    {
                        Photo = new byte[1] { 1 },
                        Caption = "Picture on jetski"
                    }
                },
                new Person
                {
                    FirstName = "Rosmarie",
                    LastName = "Carroll",
                    SocialSecurityNumber = 262230525,
                    StreetAddress = "9 Owel Blvd",
                    City = "Gooder",
                    State = "Oh",
                    ZipCode = "92952",
                    Photo = new PersonPhoto
                    {
                        Photo = new byte[1] { 1 },
                        Caption = "Picture on Mopeds"
                    }
                },
                new Person
                {
                    FirstName = "Lucy",
                    LastName = "Gash",
                    SocialSecurityNumber = 291822323,
                    StreetAddress = "269 Yourly St",
                    City = "Bolor",
                    ZipCode = "82825",
                    State = "NY",
                    Photo = new PersonPhoto
                    {
                        Photo = new byte[1] { 1 },
                        Caption = "Picture in Convertible"
                    }
                },
                new Person
                {
                    FirstName = "Rosmarie",
                    LastName = "Garza",
                    SocialSecurityNumber = 262230525,
                    StreetAddress = "9 Owel Blvd",
                    City = "Gooder",
                    State = "Oh",
                    ZipCode = "92952",
                    Photo = new PersonPhoto
                    {
                        Photo = new byte[1] { 1 },
                        Caption = "Picture play soccer"
                    }
                },
                new Person
                {
                    FirstName = "Dominic",
                    LastName = "Harding",
                    SocialSecurityNumber = 291822323,
                    StreetAddress = "269 Yourly St",
                    City = "Bolor",
                    ZipCode = "82825",
                    State = "NY",
                    Photo = new PersonPhoto
                    {
                        Photo = new byte[1] { 1 },
                        Caption = "Picture play volleyball"
                    }
                },
                new Person
                {
                    FirstName = "Kathleen",
                    LastName = "Caprio",
                    SocialSecurityNumber = 262230525,
                    StreetAddress = "9 Owel Blvd",
                    City = "Gooder",
                    State = "Oh",
                    ZipCode = "92952",
                    Photo = new PersonPhoto
                    {
                        Photo = new byte[1] { 1 },
                        Caption = "Surfing in ocean"
                    }
                });
            context.SaveChanges();
            context.Activities.AddOrUpdate(
                new Activity
                {
                    Name = "Hawaiian High Resort",
                    Trips = new List<Trip>
                    {
                        new Trip { StartDate = new DateTime(2015, 3, 15), EndDate = new DateTime(2015, 4, 15), CostUSD = 111.58M },
                        new Trip { StartDate = new DateTime(2017, 9, 30), EndDate = new DateTime(2017, 12, 22), CostUSD = 215.22M },
                        new Trip { StartDate = new DateTime(1998, 1, 12), EndDate = new DateTime(1998, 3, 10), CostUSD = 305.58M },
                        new Trip { StartDate = new DateTime(2003, 12, 3), EndDate = new DateTime(2003, 12, 31), CostUSD = 215.22M },
                        new Trip { StartDate = new DateTime(2011, 7, 14), EndDate = new DateTime(2011, 8, 25), CostUSD = 121.58M },
                        new Trip { StartDate = new DateTime(2016, 10, 16), EndDate = new DateTime(2016, 12, 22), CostUSD = 335.22M }

                    }
                },
                new Activity
                {
                    Name = "California Yosemite",
                    Trips = new List<Trip>
                    {
                        new Trip { StartDate = new DateTime(2007, 5, 17), EndDate = new DateTime(2007, 7, 10), CostUSD = 426.58M },
                        new Trip { StartDate = new DateTime(2009, 2, 27), EndDate = new DateTime(2009, 5, 31), CostUSD = 556.22M },
                        new Trip { StartDate = new DateTime(2013, 8, 27), EndDate = new DateTime(2013, 9, 25), CostUSD = 157.58M },
                        new Trip { StartDate = new DateTime(2016, 10, 30), EndDate = new DateTime(2016, 12, 5), CostUSD = 485.22M }
                    }

                },
                new Activity
                {
                    Name = "Washington Needle Tower",
                    Trips = new List<Trip>
                    {
                        new Trip { StartDate = new DateTime(1998, 1, 12), EndDate = new DateTime(1998, 3, 10), CostUSD = 477.58M },
                        new Trip { StartDate = new DateTime(2003, 12, 3), EndDate = new DateTime(2003, 12, 31), CostUSD = 98.22M },
                        new Trip { StartDate = new DateTime(2011, 7, 14), EndDate = new DateTime(2011, 8, 25), CostUSD = 145.58M },
                        new Trip { StartDate = new DateTime(2016, 10, 16), EndDate = new DateTime(2016, 12, 22), CostUSD = 308.22M }
                    }

                });
            context.SaveChanges();
            context.Trips.AddOrUpdate(
                                    new Trip
                                    {
                                        StartDate = new DateTime(2019, 9, 11),
                                        EndDate = new DateTime(2019, 11, 11),
                                        CostUSD = 257.23M,
                                        Activities = new List<Activity>
                                        {
                                                new Activity { Name = "West Coast Pardise" },
                                                new Activity { Name = "Baja Fun In Sun" },
                                                new Activity { Name = "Malibu Beach Rich" },
                                                new Activity { Name = "HollyWood High Hotels" }
                                        }
                                    },
                                    new Trip
                                    {
                                        StartDate = new DateTime(2014, 10, 10),
                                        EndDate = new DateTime(2015,1, 11),
                                        CostUSD = 257.23M,
                                        Activities = new List<Activity>
                                        {
                                            new Activity { Name = "Up and Up Fun" },
                                            new Activity { Name = "Coconut Freedom" },
                                            new Activity { Name = "Tropics Center" },
                                            new Activity { Name = "Only Fun and Sun" }
                                            }
                                    },
                                        new Trip
                                        {
                                            StartDate = new DateTime(2015, 9, 11),
                                            EndDate = new DateTime(2015, 10, 25),
                                            CostUSD = 257.23M,
                                            Activities = new List<Activity>
                                            {
                                            new Activity { Name = "Welcome Center" },
                                            new Activity { Name = "JetSki Palace" },
                                            new Activity { Name = "Hawaiian Hospitality" },
                                            new Activity { Name = "Dolphin Pardise Beach" }
                                            }
                                        });
            context.SaveChanges();

        }
    }
}
