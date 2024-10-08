﻿using System;

namespace TestToMindbox
{
    public interface IShape
    {
        double CalculateArea();
    }
    // для вычисления площади круга
    public class Circle : IShape
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    
    // для вычисления площади треугольника
    public class Triangle : IShape
    {
        private double SideA { get; }
        private double SideB { get; }
        private double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            var semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
        public bool IsRightTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-8; // 1e-8 используется для роверки, надо учесть возможные погрешности при вычислениях с плавающей точкой
        }
        
    }
    
    //Добавление новых фигур
    public class Rectangle : IShape
    {
        private double Width { get; }
        private double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
    
}
/*
 * SELECT p.ProductName, c.CategoryName
 * FROM Products p
 * LEFT JOIN PruductCatigories pc ON p.ProductId = pc.ProductID
 * LEFT JOIN Catigory c ON pc.CategoryID = c.CategoryID
 * Где Products таблица с продуктами
 * Categories таблица с катигориями
 * ProductCategories связывающая их табличка
 */