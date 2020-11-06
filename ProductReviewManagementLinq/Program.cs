using System;
using System.Collections.Generic;

namespace ProductReviewManagementLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management!");

            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Super",isLike=true},
                new ProductReview(){ProductID=2,UserID=3,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=2,UserID=5,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=7,Rating=2,Review="Okay",isLike=true},
                new ProductReview(){ProductID=5,UserID=9,Rating=1,Review="Poor",isLike=false},
                new ProductReview(){ProductID=4,UserID=11,Rating=5,Review="Super",isLike=true},
                new ProductReview(){ProductID=7,UserID=10,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=7,UserID=15,Rating=3,Review="Good",isLike=false},
                new ProductReview(){ProductID=8,UserID=17,Rating=2,Review="Okay",isLike=true},
                new ProductReview(){ProductID=20,UserID=10,Rating=1,Review="Poor",isLike=true},
                new ProductReview(){ProductID=11,UserID=19,Rating=5,Review="Super",isLike=false},
                new ProductReview(){ProductID=17,UserID=21,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=10,UserID=10,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=18,UserID=25,Rating=2,Review="Okay",isLike=false},
                new ProductReview(){ProductID=15,UserID=27,Rating=1,Review="Poor",isLike=true},
                new ProductReview(){ProductID=10,UserID=10,Rating=5,Review="Super",isLike=false},
                new ProductReview(){ProductID=17,UserID=31,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=11,UserID=33,Rating=3,Review="Good",isLike=false},
                new ProductReview(){ProductID=19,UserID=10,Rating=2,Review="Okay",isLike=true},
                new ProductReview(){ProductID=20,UserID=37,Rating=1,Review="Poor",isLike=false},
                new ProductReview(){ProductID=16,UserID=10,Rating=5,Review="Super",isLike=true},
                new ProductReview(){ProductID=22,UserID=10,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=23,UserID=43,Rating=3,Review="Good",isLike=false},
                new ProductReview(){ProductID=14,UserID=45,Rating=2,Review="Okay",isLike=false},
                new ProductReview(){ProductID=5,UserID=47,Rating=1,Review="Poor",isLike=true},
            };
            //foreach (var list in listProductReview)
            //{
            //    Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            //}
            Management mg = new Management();
            //mg.TopRecords(listProductReview);
            //mg.RecordWithCondition(listProductReview);
            //mg.RetrieveCountOfReview(listProductReview);
            //mg.RetrieveProductIdAndReview(listProductReview);
            //mg.SkipTop5records(listProductReview);
            //mg.CreateDataTable();
            //mg.AverageRatingOfEachProductId(listProductReview);
            //mg.RecordWithReviewGood(listProductReview);
            //mg.RetrieveRecordsWithUserId10(listProductReview);
            mg.GetAllLikedReviews();
        }
    }
}
