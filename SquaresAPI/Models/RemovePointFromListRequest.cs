﻿namespace SquaresAPI.Models
{
    public class RemovePointFromListRequest
    {
        public int PointsListId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}