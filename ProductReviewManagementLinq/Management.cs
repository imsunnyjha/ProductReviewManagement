using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace ProductReviewManagementLinq
{
    public class Management
    {
        public readonly DataTable dt = new DataTable();
        /// <summary>
        /// UC2
        /// </summary>
        /// <param name="listProductReview"></param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3).ToList();
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            }
        }
        public void RecordWithCondition(List<ProductReview> listProductReview)
        {
            var data = (from productReviews in listProductReview
                        where (productReviews.Rating > 3 && productReviews.ProductID == 1) ||(productReviews.Rating > 3 && productReviews.ProductID == 4) 
                                || (productReviews.Rating > 3 && productReviews.ProductID == 9)
                        select productReviews).ToList();
            Console.WriteLine("\n");
            foreach (var list in data)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            }
        }

    }
}
