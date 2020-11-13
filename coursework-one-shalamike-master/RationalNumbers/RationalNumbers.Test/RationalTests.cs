using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RationalNumbers.Test
{
    [TestClass]
    public class RationalTests
    {
        [TestMethod]
        public void Add_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2) + new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(23, 20), new RationalNumber(3, 4) + new RationalNumber(2, 5));
            Assert.AreEqual(new RationalNumber(97, 84), new RationalNumber(7, 12) + new RationalNumber(4, 7));
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(12, 24) + new RationalNumber(48, 72));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(50, 100) + new RationalNumber(100, 200));
            Assert.AreEqual(new RationalNumber(2, 3), new RationalNumber(100, 300) + new RationalNumber(20, 60));
            Assert.AreEqual(new RationalNumber(2487, 3416), new RationalNumber(27, 56) + new RationalNumber(15, 61));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Add_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(-1, 6), new RationalNumber(1, 2) + new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(-7, 20), new RationalNumber(-3, 4) + new RationalNumber(2, 5));
            Assert.AreEqual(new RationalNumber(-1, 84), new RationalNumber(-7, 12) + new RationalNumber(4, 7));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(123, 246) + new RationalNumber(-512, 1024));
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(6, 8) + new RationalNumber(-56, 224));
            Assert.AreEqual(new RationalNumber(1, 3), new RationalNumber(5000, 5000) + new RationalNumber(-444, 666));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(44, 220) + new RationalNumber(-33, 165));
            Assert.AreEqual(new RationalNumber(154961, 753389), new RationalNumber(154, 487) + new RationalNumber(-171, 1547));
            
            
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Add_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(-7, 6), new RationalNumber(-1, 2) + new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(-7, 6), new RationalNumber(-1, 2) + new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(-23, 20), new RationalNumber(-3, 4) + new RationalNumber(-2, 5));
            Assert.AreEqual(new RationalNumber(-97, 84), new RationalNumber(-7, 12) + new RationalNumber(-4, 7));
            Assert.AreEqual(new RationalNumber(-2487, 3416), new RationalNumber(-27, 56) + new RationalNumber(-15, 61));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Add_a_rational_number_to_its_additive_inverse()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) + new RationalNumber(-1, 2));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(5, 12) + new RationalNumber(-5, 12));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(343, 34345) + new RationalNumber(-343, 34345));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(12386, 484154) + new RationalNumber(-12386, 484154));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Subtract_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(-1, 6), new RationalNumber(1, 2) - new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(1, 84), new RationalNumber(7, 12) - new RationalNumber(4, 7));
            Assert.AreEqual(new RationalNumber(607, 3116), new RationalNumber(45, 123) - new RationalNumber(78, 456));
            Assert.AreEqual(new RationalNumber(-439, 1265), new RationalNumber(12, 55) - new RationalNumber(13, 23));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Subtract_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2) - new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(53, 60), new RationalNumber(7, 12) - new RationalNumber(-3, 10));
            Assert.AreEqual(new RationalNumber(11351, 19285), new RationalNumber(57, 145) - new RationalNumber(-26, 133));
            Assert.AreEqual(new RationalNumber(169579, 184072), new RationalNumber(123, 456) - new RationalNumber(-789, 1211));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Subtract_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(1, 6), new RationalNumber(-1, 2) - new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(1, 6), new RationalNumber(-1, 2) - new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(-1, 60), new RationalNumber(-3, 5) - new RationalNumber(-7, 12));
            Assert.AreEqual(new RationalNumber(-154961, 753389), new RationalNumber(-154, 487) - new RationalNumber(-171, 1547));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Subtract_a_rational_number_from_itself()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) - new RationalNumber(1, 2));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(23, 79) - new RationalNumber(23, 79));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(58, 59) - new RationalNumber(58, 59));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(-784, 45615) - new RationalNumber(-784, 45615));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Multiply_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(1, 3), new RationalNumber(1, 2) * new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(93, 104), new RationalNumber(31, 64) * new RationalNumber(24, 13));
            Assert.AreEqual(new RationalNumber(35, 108), new RationalNumber(7, 12) * new RationalNumber(5, 9));
            Assert.AreEqual(new RationalNumber(39, 49), new RationalNumber(132, 154) * new RationalNumber(143, 154));
            Assert.AreEqual(new RationalNumber(3, 5), new RationalNumber(24, 32) * new RationalNumber(4, 5));
            Assert.AreEqual(new RationalNumber(8, 15), new RationalNumber(2, 3) * new RationalNumber(4, 5));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Multiply_a_negative_rational_number_by_a_positive_rational_number()
        {
            Assert.AreEqual(new RationalNumber(-1, 3), new RationalNumber(-1, 2) * new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(-93, 104), new RationalNumber(-31, 64) * new RationalNumber(24, 13));
            Assert.AreEqual(new RationalNumber(-35, 108), new RationalNumber(7, 12) * new RationalNumber(-5, 9));
            Assert.AreEqual(new RationalNumber(-39, 49), new RationalNumber(132, -154) * new RationalNumber(143, 154));
            Assert.AreEqual(new RationalNumber(-3, 5), new RationalNumber(24, 32) * new RationalNumber(4, -5));
            Assert.AreEqual(new RationalNumber(-8, 15), new RationalNumber(-2, 3) * new RationalNumber(4, 5));
            
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Multiply_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(1, 3), new RationalNumber(-1, 2) * new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(315, 704), new RationalNumber(-15, 32) * new RationalNumber(-42, 44));
            Assert.AreEqual(new RationalNumber(39, 49), new RationalNumber(-132, 154) * new RationalNumber(143, -154));
            Assert.AreEqual(new RationalNumber(3, 5), new RationalNumber(24, -32) * new RationalNumber(-4, 5));
            Assert.AreEqual(new RationalNumber(8, 15), new RationalNumber(-2, 3) * new RationalNumber(4, -5));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Multiply_a_rational_number_by_its_reciprocal()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 2) * new RationalNumber(2, 1));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(12, 24) * new RationalNumber(24, 12));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(57, 63) * new RationalNumber(63, 57));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(88, 192) * new RationalNumber(192, 88));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(7, 4) * new RationalNumber(4, 7));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Multiply_a_rational_number_by_1()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2) * new RationalNumber(1, 1));
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(12, 24) * new RationalNumber(1, 1));
            Assert.AreEqual(new RationalNumber(1, 3), new RationalNumber(1, 1) * new RationalNumber(23, 69));
            Assert.AreEqual(new RationalNumber(4, 5), new RationalNumber(28, 35) * new RationalNumber(1, 1));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Multiply_a_rational_number_by_0()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) * new RationalNumber(0, 1));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) * new RationalNumber(0, 784841));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(3, 656) * new RationalNumber(0, 4));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(4343, 223424) * new RationalNumber(0, 12));
        }
        
        // my own added test case for multiplying
        //[Ignore("Skip")]
        [TestMethod]
        public void Multiplying_Whole_numbers()
        {
            Assert.AreEqual(new RationalNumber(20, 1), new RationalNumber(4, 1) * new RationalNumber(5, 1));
            Assert.AreEqual(new RationalNumber(45, 1), new RationalNumber(5, 1) * new RationalNumber(9, 1));
            Assert.AreEqual(new RationalNumber(121, 1), new RationalNumber(11, 1) * new RationalNumber(11, 1));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Divide_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(1, 2) / new RationalNumber(2, 3));
            Assert.AreEqual(new RationalNumber(6, 25), new RationalNumber(23, 69) / new RationalNumber(100, 72));
            Assert.AreEqual(new RationalNumber(41, 35), new RationalNumber(3, 63) / new RationalNumber(5, 123));
            Assert.AreEqual(new RationalNumber(132, 91), new RationalNumber(11, 13) / new RationalNumber(7, 12));
            Assert.AreEqual(new RationalNumber(52, 35), new RationalNumber(13, 15) / new RationalNumber(7, 12));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Divide_a_positive_rational_number_by_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(-3, 4), new RationalNumber(1, 2) / new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(-6, 25), new RationalNumber(-23, 69) / new RationalNumber(100, 72));
            Assert.AreEqual(new RationalNumber(-41, 35), new RationalNumber(3, 63) / new RationalNumber(-5, 123));
            Assert.AreEqual(new RationalNumber(-132, 91), new RationalNumber(11, 13) / new RationalNumber(7, -12));
            Assert.AreEqual(new RationalNumber(-52, 35), new RationalNumber(13, -15) / new RationalNumber(7, 12));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Divide_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(-1, 2) / new RationalNumber(-2, 3));
            Assert.AreEqual(new RationalNumber(6, 25), new RationalNumber(23, -69) / new RationalNumber(-100, 72));
            Assert.AreEqual(new RationalNumber(41, 35), new RationalNumber(-3, 63) / new RationalNumber(5, -123));
            Assert.AreEqual(new RationalNumber(132, 91), new RationalNumber(11, -13) / new RationalNumber(-7, 12));
            Assert.AreEqual(new RationalNumber(52, 35), new RationalNumber(-13, 15) / new RationalNumber(7, -12));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Divide_a_rational_number_by_1()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2) / new RationalNumber(1, 1));
            Assert.AreEqual(new RationalNumber(2, 3), new RationalNumber(2, 3) / new RationalNumber(1, 1));
            Assert.AreEqual(new RationalNumber(5, 12), new RationalNumber(5, 12) / new RationalNumber(1, 1));
            Assert.AreEqual(new RationalNumber(7, 9), new RationalNumber(21, 27) / new RationalNumber(1, 1));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Absolute_value_of_a_positive_rational_number()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2).Abs());
            Assert.AreEqual(new RationalNumber(2, 3), new RationalNumber(2, 3).Abs());
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(3, 4).Abs());
            Assert.AreEqual(new RationalNumber(5, 6), new RationalNumber(5, 6).Abs());
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Absolute_value_of_a_positive_rational_number_with_negative_numerator_and_denominator()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(-1, -2).Abs());
            Assert.AreEqual(new RationalNumber(2, 3), new RationalNumber(-2, -3).Abs());
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(-3, -4).Abs());
            Assert.AreEqual(new RationalNumber(5, 6), new RationalNumber(-5, -6).Abs());
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Absolute_value_of_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(-1, 2).Abs());
            Assert.AreEqual(new RationalNumber(2, 3), new RationalNumber(-2, 3).Abs());
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(-3, 4).Abs());
            Assert.AreEqual(new RationalNumber(5, 6), new RationalNumber(-5, 6).Abs());
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Absolute_value_of_a_negative_rational_number_with_negative_denominator()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, -2).Abs());
            Assert.AreEqual(new RationalNumber(2, 3), new RationalNumber(2, -3).Abs());
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(3, -4).Abs());
            Assert.AreEqual(new RationalNumber(5, 6), new RationalNumber(5, -6).Abs());
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Absolute_value_of_zero()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 1).Abs());
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 2).Abs());
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, -53).Abs());
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, -321).Abs());
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Raise_a_positive_rational_number_to_a_positive_integer_power()
        {
            Assert.AreEqual(new RationalNumber(1, 8), new RationalNumber(1, 2).ExpRational(3));
            Assert.AreEqual(new RationalNumber(1, 4), new RationalNumber(1, 2).ExpRational(2));
            Assert.AreEqual(new RationalNumber(1, 32), new RationalNumber(1, 2).ExpRational(5));
            Assert.AreEqual(new RationalNumber(1, 16), new RationalNumber(1, 2).ExpRational(4));
            Assert.AreEqual(new RationalNumber(1, 4096), new RationalNumber(1, 2).ExpRational(12));
            Assert.AreEqual(new RationalNumber(1, 531441), new RationalNumber(1, 3).ExpRational(12));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Raise_a_negative_rational_number_to_a_positive_integer_power()
        {
            Assert.AreEqual(new RationalNumber(-1, 8), new RationalNumber(-1, 2).ExpRational(3));
            Assert.AreEqual(new RationalNumber(1, 4), new RationalNumber(1, -2).ExpRational(2));
            Assert.AreEqual(new RationalNumber(-1, 32), new RationalNumber(-1, 2).ExpRational(5));
            Assert.AreEqual(new RationalNumber(1, 16), new RationalNumber(1, -2).ExpRational(4));
            Assert.AreEqual(new RationalNumber(1, 4096), new RationalNumber(-1, 2).ExpRational(12));
            Assert.AreEqual(new RationalNumber(1, 531441), new RationalNumber(1, -3).ExpRational(12));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Raise_zero_to_an_integer_power()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 1).ExpRational(5));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 32).ExpRational(51));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 11).ExpRational(-2));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 16).ExpRational(1));
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 199).ExpRational(-4));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Raise_one_to_an_integer_power()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 1).ExpRational(4));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1434, 1434).ExpRational(2));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(-21, -21).ExpRational(6));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(-121, -121).ExpRational(2));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Raise_a_positive_rational_number_to_the_power_of_zero()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 2).ExpRational(0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(5, 6).ExpRational(0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(8, 4).ExpRational(0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(8, 12354).ExpRational(0));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Raise_a_negative_rational_number_to_the_power_of_zero()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(-1, 2).ExpRational(0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(11, -243).ExpRational(0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(-13, 22).ExpRational(0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(12, -23).ExpRational(0));
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(123, -245).ExpRational(0));
        }
        
        // added more test cases for raising a number by power of a negative integer 
        //[Ignore("Skip")]
        [TestMethod]
        public void raise_positive_number_by_value_of_negative_number()
        {
            Assert.AreEqual(new RationalNumber(9, 4), new RationalNumber(2, 3).ExpRational(-2));
            Assert.AreEqual(new RationalNumber(64, 27), new RationalNumber(3, 4).ExpRational(-3));
            Assert.AreEqual(new RationalNumber(1024, 3125), new RationalNumber(5, 4).ExpRational(-5));
            Assert.AreEqual(new RationalNumber(64, 1), new RationalNumber(1, 2).ExpRational(-6));
        }
        
        // added more test cases for raising a negative number by power of a negative integer 
        //[Ignore("Skip")]
        [TestMethod]
        public void raise_positive_negative_by_value_of_negative_number()
        {
            Assert.AreEqual(new RationalNumber(9, 4), new RationalNumber(-2, 3).ExpRational(-2));
            Assert.AreEqual(new RationalNumber(-64, 27), new RationalNumber(3, -4).ExpRational(-3));
            Assert.AreEqual(new RationalNumber(729, 64), new RationalNumber(-2, 3).ExpRational(-6));
            Assert.AreEqual(new RationalNumber(64, 1), new RationalNumber(1, -2).ExpRational(-6));
            Assert.AreEqual(new RationalNumber(-128, 1), new RationalNumber(1, -2).ExpRational(-7));
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Raise_a_real_number_to_a_positive_rational_number()
        {
            Assert.AreEqual(16, 8.ExpReal(new RationalNumber(4, 3)), 0.0000001);
            Assert.AreEqual(8, 4.ExpReal(new RationalNumber(3, 2)), 0.0000001);
            Assert.AreEqual(27, 9.ExpReal(new RationalNumber(3, 2)), 0.0000001);
            Assert.AreEqual(3.9482221, 3.ExpReal(new RationalNumber(5, 4)), 0.0000001);
            Assert.AreEqual(243, 81.ExpReal(new RationalNumber(5, 4)), 0.0000001);
            Assert.AreEqual(2.1810155, 2.ExpReal(new RationalNumber(9, 8)), 0.0000001);
            
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Raise_a_real_number_to_a_negative_rational_number()
        {
            Assert.AreEqual(0.33333334, 9.ExpReal(new RationalNumber(-1, 2)), 0.0000001);
            Assert.AreEqual(0.4807499, 3.ExpReal(new RationalNumber(-2, 3)), 0.0000001);
            Assert.AreEqual(0.2990698, 5.ExpReal(new RationalNumber(-3, 4)), 0.0000001);
            Assert.AreEqual(0.1111112, 27.ExpReal(new RationalNumber(-2, 3)), 0.0000001);
            Assert.AreEqual(0.0625, 256.ExpReal(new RationalNumber(-2, 4)), 0.0000001);
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Raise_a_real_number_to_a_zero_rational_number()
        {
            Assert.AreEqual(1, 2.ExpReal(new RationalNumber(0, 1)), 0.0000001);
            Assert.AreEqual(1, 5.ExpReal(new RationalNumber(0, 1)), 0.0000001);
            Assert.AreEqual(1, 7.ExpReal(new RationalNumber(0, 1)), 0.0000001);
            Assert.AreEqual(-1, -3.ExpReal(new RationalNumber(0, 1)), 0.0000001);
            Assert.AreEqual(1, 23.ExpReal(new RationalNumber(0, 1)), 0.0000001);
            Assert.AreEqual(-1, -1024.ExpReal(new RationalNumber(0, 1)), 0.0000001);
            Assert.AreEqual(1, 4875.ExpReal(new RationalNumber(0, 1)), 0.0000001);
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Reduce_a_positive_rational_number_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(2, 4).Reduce());
            Assert.AreEqual(new RationalNumber(2, 3), new RationalNumber(262, 393).Reduce());
           
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Reduce_a_negative_rational_number_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(-2, 3), new RationalNumber(-4, 6).Reduce());
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Reduce_a_rational_number_with_a_negative_denominator_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(-1, 3), new RationalNumber(3, -9).Reduce());
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Reduce_zero_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 6).Reduce());
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 41).Reduce());
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 76).Reduce());
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 3).Reduce());
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Reduce_an_integer_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(-2, 1), new RationalNumber(-14, 7).Reduce());
            Assert.AreEqual(new RationalNumber(4, 1), new RationalNumber(16, 4).Reduce());
            Assert.AreEqual(new RationalNumber(-3, 1), new RationalNumber(-15, 5).Reduce());
            Assert.AreEqual(new RationalNumber(11, 1), new RationalNumber(121, 11).Reduce());
        }

        //[Ignore("Skip")]
        [TestMethod]
        public void Reduce_one_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(13, 13).Reduce());
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(26, 26).Reduce());
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(4, 4).Reduce());
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(785, 785).Reduce());
        }
    }
}