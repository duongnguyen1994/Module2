using System;

namespace Triangle.Service
{
    public class TriangleClassifier
    {
        public string ClassifyTriangle(int firstEdge, int secondEdge, int thirdEdge)
        {     
            if (IsTriangle(firstEdge,secondEdge,thirdEdge))
            {
                if(CheckFirstEdgeEqualsSecondEdge(firstEdge,secondEdge) && CheckFirstEdgeEqualsThirdEdge(firstEdge, thirdEdge))
                {
                return "Equilateral Triangle";
                }
                else if(CheckFirstEdgeEqualsSecondEdge(firstEdge,secondEdge) || CheckFirstEdgeEqualsThirdEdge(firstEdge, thirdEdge) || secondEdge == thirdEdge)
                {
                    return "Isosceles Triangle";
                }
                return "Normal Triangle";
            }      
            return "This is not a Triangle";
        }
        public bool IsTriangle(int firstEdge, int secondEdge, int thirdEdge)
        {
            if (firstEdge+secondEdge>thirdEdge&&firstEdge+thirdEdge>secondEdge&&secondEdge+thirdEdge>firstEdge)
            {
                return true;
            }
            return false;
        }
        public bool CheckFirstEdgeEqualsSecondEdge(int firstEdge, int secondEdge)
        {
            if (firstEdge == secondEdge)
            {
                return true;
            }
            return false;
        }
        public bool CheckFirstEdgeEqualsThirdEdge(int firstEdge, int thirdEdge)
        {
            if (firstEdge == thirdEdge)
            {
                return true;
            }
            return false;
        }
    }
}
