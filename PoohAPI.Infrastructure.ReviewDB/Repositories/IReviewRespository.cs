﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoohAPI.Infrastructure.ReviewDB.Models;

namespace PoohAPI.Infrastructure.ReviewDB.Repositories
{
    public interface IReviewRepository
    {
        IEnumerable<DBReview> GetAllReviews(int maxCount, int offset);
        DBReview GetReview(string query, Dictionary<string, object> parameters);
        DBReview GetReview(string query);
        void UpdateReview(string query, Dictionary<string, object> parameters);
        void DeleteReview(string query, Dictionary<string,object> parameters);
        int PostReview(string query, Dictionary<string, object> parameters);
        IEnumerable<DBReviewId> GetListReviewIds(string query, Dictionary<string, object> parameters);
        IEnumerable<DBReview> GetListReviews(string query, Dictionary<string, object> parameters);
    }
}
