﻿using ProductService.Domain;
using System.Collections.Generic;

namespace ProductService.DataAccess.EF.Data
{
    internal static class DemoProductFactory
    {
        internal static Product Travel()
        {
            Product p = new Product(
                    "TRI",
                    "Safe Traveller",
                    "/static/travel.jpg",
                    "Travel insurance",
                    10);

            p.AddCover("C2", "Illness", "", false, 5000);
            p.AddCover("C3", "Assistance", "", true, null);

            p.AddQuestions(new List<Question> { new ChoiceQuestion("DESTINATION", 1, "Destination", new List<Choice> {
                            new Choice("EUR", "Europe"),
                            new Choice("WORLD", "World"),
                            new Choice("PL", "Poland")
            })
                    ,
                    new NumericQuestion("NUM_OF_ADULTS", 2, "Number of adults"),
                    new NumericQuestion("NUM_OF_CHILDREN", 3, "Number of children")
            });
            return p;
        }


        internal static Product House()
        {
            Product p = new Product(
                    "HSI",
                    "Happy House",
                    "/static/house.jpg",
                    "House insurance",
                    5);

            p.AddCover("C1", "Fire", "", false, 200000);
            p.AddCover("C2", "Flood", "", false, 100000);
            p.AddCover("C3", "Theft", "", false, 50000);
            p.AddCover("C4", "Assistance", "", true, null);

            p.AddQuestions(new List<Question> {
                    new ChoiceQuestion("TYP", 1, "Apartment / House", new List<Choice> {
                            new Choice("APT", "Apartment"),
                            new Choice("HOUSE", "House")
                    }),
                    new NumericQuestion("AREA", 2, "Area"),
                    new NumericQuestion("NUM_OF_CLAIM", 3, "Number of claims in last 5 years"),
                    new ChoiceQuestion("FLOOD", 4, "Located in flood risk area", ChoiceQuestion.YesNoChoice())
            });
            return p;
        }

        internal static Product Farm()
        {
            Product p = new Product(
                    "FAI",
                    "Happy farm",
                    "/static/farm.jpg",
                    "Farm insurance",
                    1);

            p.AddCover("C1", "Crops", "", false, 200000);
            p.AddCover("C2", "Flood", "", false, 100000);
            p.AddCover("C3", "Fire", "", false, 50000);
            p.AddCover("C4", "Equipment", "", true, 300000);

            p.AddQuestions(new List<Question> {
                    new ChoiceQuestion("TYP", 1, "Cultivation type", new List<Choice> {
                            new Choice("ZB", "Crop"),
                            new Choice("KW", "Vegetable")
                    }),
                    new NumericQuestion("AREA", 2, "Area"),
                    new NumericQuestion("NUM_OF_CLAIM", 3, "Number of claims in last 5 years"),
                    //new ChoiceQuestion("FLOOD", 4, "Located in flood risk area", ChoiceQuestion.YesNoChoice()) //FIXME problem with code duplication
            });
            return p;
        }

        internal static Product Car()
        {
            Product p = new Product(
                    "CAR",
                    "Happy Driver",
                    "/static/car.jpg",
                    "Car insurance",
                    1);

            p.AddCover("C1", "Assistance", "", true, null);
            p.AddQuestions(new List<Question> {
                    new NumericQuestion("NUM_OF_CLAIM", 3, "Number of claims in last 5 years")
            });

            return p;
        }
    }
}
