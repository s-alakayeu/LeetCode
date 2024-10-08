﻿using System.Reflection.PortableExecutable;
using LeetCode.Explore;
using LeetCode.Questions;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leaf_Similar_Trees_872.LeafSimilar(Leaf_Similar_Trees_872.GetRoot1(), Leaf_Similar_Trees_872.GetRoot2());
            // Find_First_Palindromic_String_in_the_Array_2108.FirstPalindrome(["abc", "car", "ada", "racecar", "cool"]);
            // Rearrange_Array_Elements_by_Sign_2149.RearrangeArray([3, 1, -2, -5, 2, -4]);
            // var result = Find_Polygon_With_the_Largest_Perimeter_2971.LargestPerimeter([1,12,1,2,5,50,3]);
            // Bitwise_AND_of_Numbers_Range_201.RangeBitwiseAnd(0, 0);
            // Find_the_Town_Judge_997.FindJudge(2, [[1,2]]);
            // Reverse_Linked_List.ReverseList(Reverse_Linked_List.PrepareData());
            // Remove_Linked_List_Elements.RemoveElements(Remove_Linked_List_Elements.PrepareData(), 6);
            // Odd_Even_Linked_List.OddEvenList(Odd_Even_Linked_List.PrepareData());
            // Palindrome_Linked_List.IsPalindrome(Palindrome_Linked_List.PrepareData());
            // Intersection_of_Two_Arrays_349.Intersection([1, 2, 2, 1], [2, 2]);
            // Custom_Sort_String_791.CustomSortString("cba", "abcd");
            // Merge_Two_Sorted_Lists_21.MergeTwoLists(Merge_Two_Sorted_Lists_21.PrepareData1(), Merge_Two_Sorted_Lists_21.PrepareData2());
            // Add_Two_Numbers_2.AddTwoNumbers(Add_Two_Numbers_2.PrepareDataFirst(), Add_Two_Numbers_2.PrepareDataSecond());
            //Remove_Zero_Sum_Consecutive_Nodes_from_Linked_List_1171.RemoveZeroSumSublists(Remove_Zero_Sum_Consecutive_Nodes_from_Linked_List_1171.PrepareData());
            // Find_the_Pivot_Integer_2485.PivotInteger(8);
            // Height_Checker_1051.HeightChecker([1, 1, 4, 2, 1, 3]);
            // Insertion_Sort_List_147.InsertionSortList(Insertion_Sort_List_147.PrepareData());
            // Binary_Subarrays_With_Sum_930.NumSubarraysWithSum([1, 0, 1, 0, 1], 2);
            // Product_of_Array_Except_Self_238.ProductExceptSelf([1, 2, 3, 4]);
            // Contiguous_Array_525.FindMaxLength([0,0,1,0,0,0,1,1]);
            // Insert_Interval_57.Insert([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4,8]);
            // Minimum_Number_of_Arrows_to_Burst_Balloons_425.FindMinArrowShots([[3,9],[7,12],[3,8],[6,8],[9,10],[2,9],[0,9],[3,9],[0,6],[2,8]]);
            // Task_Scheduler_621.LeastInterval(['A', 'A', 'A', 'B', 'B', 'B'], 3);
            // Merge_In_Between_Linked_Lists_1669.MergeInBetween(Merge_In_Between_Linked_Lists_1669.PrepareNodeA(), 3, 4, Merge_In_Between_Linked_Lists_1669.PrepareNodeB());
            // Find_All_Duplicates_in_an_Array_442.FindDuplicates([4, 3, 2, 7, 8, 2, 3, 1]);
            // First_Missing_Positive_41.FirstMissingPositive([3, 4, -1, 1]);
            // Subarray_Product_Less_Than_K_713.NumSubarrayProductLessThanK([10, 5, 2, 6], 100);
            // Isomorphic_Strings_205.IsIsomorphic("badc", "baba");
            // Make_The_String_Great_1544.MakeGood("abBAcC");
            // Time_Needed_to_Buy_Tickets_2073.TimeRequiredToBuy([2, 3, 2], 2);
            // Reveal_Cards_In_Increasing_Order_950.DeckRevealedIncreasing([17, 13, 11, 2, 3, 5, 7]);
            // Remove_K_Digits_402.RemoveKDigits("1432219", 3);
            // Sum_Root_to_Leaf_Numbers_129.SumNumbers(Sum_Root_to_Leaf_Numbers_129.PrepareTree());
            // Smallest_String_Starting_From_Leaf_988.SmallestFromLeaf(Smallest_String_Starting_From_Leaf_988.PrepareNode());
            // Island_Perimeter_463.IslandPerimeter([[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]]);
            // Find_if_Path_Exists_in_Graph_1971.ValidPath(3, [[0, 1], [1, 2], [2, 0]], 0 , 2);
            // Open_the_Lock_752.OpenLock(["0201", "0101", "0102", "1212", "2002"], "0202");
            // Longest_Ideal_Subsequence_2370.LongestIdealString("acfgbd", 2);
            // Minimum_Falling_Path_Sum_II_1289.MinFallingPathSum([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);
            // Minimum_Number_of_Operations_to_Make_Array_XOR_Equal_to_K_2997.MinOperations([2, 1, 3, 4], 1);
            // Number_of_Wonderful_Substrings_1915.WonderfulSubstrings("aba");
            // Compare_Version_Numbers_165.CompareVersion("11", "10");
            // Double_a_Number_Represented_as_a_Linked_List_2816.DoubleIt(Double_a_Number_Represented_as_a_Linked_List_2816.PrepareInput());
            // Relative_Ranks_506.FindRelativeRanks([10, 3, 8, 9, 4]);
            // HeapSort.SortArray([5, 2, 3, 1]);
            // K_th_Smallest_Prime_Fraction_786.KthSmallestPrimeFraction([1, 2, 3, 5], 3);
            // Largest_Local_Values_in_a_Matrix_2373.LargestLocal([[9, 9, 8, 1], [5, 6, 2, 6], [8, 2, 6, 4], [6, 2, 2, 2]]);
            // Score_After_Flipping_Matrix_861.MatrixScore([[0, 0, 1, 1], [1, 0, 1, 0], [1, 1, 0, 0]]);
            // Path_with_Maximum_Gold_1219.GetMaximumGold([[0, 6, 0], [5, 8, 7], [0, 9, 0]]);
            // Distribute_Coins_in_Binary_Tree_979.DistributeCoins(Distribute_Coins_in_Binary_Tree_979.PrepareResult());
            // Sum_of_All_Subset_XOR_Totals_1863.SubsetXORSum([5, 1, 6]);
            // Subsets_78.Subsets([1, 2, 3]);
            // The_Number_of_Beautiful_Subsets_2597.BeautifulSubsets([1,1,2,3], 1);
            // Special_Array_With_X_Elements_Greater_Than_or_Equal_X_1608.SpecialArray([0, 4, 3, 0, 4]);
            // Get_Equal_Substrings_Within_Budget_1208.EqualSubstring("abcd", "bcdf", 3);
            // Number_of_Steps_to_Reduce_a_Number_in_Binary_Representation_to_One_1404.NumSteps("1101");
            // Single_Number_III_260.SingleNumber([1,2,1,3,2,5]);
            // Score_of_a_String_3110.ScoreOfString("hello");
            // Reverse_String_344.ReverseString("hello".ToCharArray());
            // Append_Characters_to_String_to_Make_Subsequence_2486.AppendCharacters("lbg", "g");
            // Longest_Palindrome_409.LongestPalindrome("abccccdd");
            // Find_Common_Characters_1002.CommonChars(["cool","lock","cook"]);
            // Hand_of_Straights_846.IsNStraightHand([1, 2, 3, 6, 2, 3, 4, 7, 8], 3);
            /*Replace_Words_648.ReplaceWords(
                [
                    "ll", "now", "uap", "xn", "mtxbk", "en", "ifm", "tty", "j", "i", "ezfyt", "k", "wpl", "rnw", "yuuax", "fvy", "km", "ewko", "suvti", "ddv", "dzrfc", "f", "nkyb",
                    "cpme", "ensn", "bjh", "soacg", "gd", "a", "lcwbs", "pjze", "bwlm", "svk", "um", "rpy", "mwyo", "iqj", "hsiki", "yv", "sdtd", "jns", "cfadn", "gxotu", "uoj",
                    "xzao", "ug", "qnlvo", "fgbp", "dx", "m", "wp", "yoyf", "fyzl", "z", "mjcso", "s", "b", "u", "ad", "zrerd", "pyxxs", "g", "pgakz", "v", "owrpk", "slhb", "rprt"
                ],
                "zsyrupfxkwyzxnfkb nvsxmebaqwtejtdikjdb owabmqdbbo ltorldoq w xuyjdxmov hamjfoeae sqlftbmeywleeiscndj p jxu zoslotzcttjnbotki wyhyyueudixnorx vdglkopp cfakarjbf aboaszt onbffyfr cjpfrjqkolnamygqqj uwphkibxemxensz zouhcybstkbdyg ubfwglanyquhwlrglvc givqubayvmrvholkcke vkvyjrjraiollmlt npofa ffwnkttyp gwabsiibv vy tyrsvbuxticx e zfksmowe pdrlwocngdlpv n ouylngqjxilaqlkn zbxhafxxpvjkqpwdsy ssnsy itufigmudtvbv jw sfupomzekekabo caas nkmgrpuhskf rhifdognhfdoo pzecptqfzfvoa jzdlf zkcerlkxxqjy xzkwdgergjosa hgbovwtpzcpwtlwy tly ibtefvaozlsxo jopulkb mmgngozepqlpnqhvkn vwlbuktoipbncdnzhud urnocwb yfsrzjtvbt ybqbkflsz evlxlycwmlttaxlxdfjg xk tjjruytuikaucpcfxr ktbgnifciauv asvclppedfhf mldkna kbqtlbdwgftpzbojvsxm smzgn kyx zgclfw nsywjvgdicwccdoknm rhelltyrist fcijinwjev t");*/
            // Continuous_Subarray_Sum_523.CheckSubarraySum([23,2,6,4,7], 13);
            // Subarray_Sums_Divisible_by_K_974.SubarraysDivByK([4, 5, 0, -2, -3, 1], 5);
            // Relative_Sort_Array_1122.RelativeSortArray([2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19], [2, 1, 4, 3, 9, 6]);
            // Minimum_Number_of_Moves_to_Seat_Everyone_2037.MinMovesToSeat([4, 1, 5, 9], [1, 3, 2, 6]);
            // Minimum_Increment_to_Make_Array_Unique_945.MinIncrementForUnique([3, 2, 1, 2, 1, 7]);
            // Patching_Array_330.MinPatches([1, 5, 10], 20);
            // Sum_of_Square_Numbers_633.JudgeSquareSum(5);
            // Minimum_Number_of_Days_to_Make_m_Bouquets_1482.MinDays([7, 7, 7, 7, 12, 7, 7], 2, 3);
            // Magnetic_Force_Between_Two_Balls_1552.MaxDistance([1, 2, 3, 4, 7], 3);
            // Grumpy_Bookstore_Owner_1052.MaxSatisfied([1, 0, 1, 2, 1, 1, 7, 5], [0, 1, 0, 1, 0, 1, 0, 1], 3);
            // Longest_Continuous_Subarray_With_Absolute_Diff_Less_Than_or_Equal_to_Limit_1438.LongestSubarray([1,5,6,7,8,10,6,5,6], 4);
            // Binary_Search_Tree_to_Greater_Sum_Tree_1038.BstToGst(Binary_Search_Tree_to_Greater_Sum_Tree_1038.PrepareData());
            // Balance_a_Binary_Search_Tree_1382.BalanceBST(Balance_a_Binary_Search_Tree_1382.PrepareData());
            // Find_Center_of_Star_Graph_1791.FindCenter([[1, 2], [2, 3], [4, 2]]);
            // All_Ancestors_of_a_Node_in_a_Directed_Acyclic_Graph_2192.GetAncestors(6, [[0,3],[5,0],[2,3],[4,3],[5,3],[1,3],[2,5],[0,1],[4,5],[4,2],[4,0],[2,1],[5,1]]);
            // Three_Consecutive_Odds_1550.ThreeConsecutiveOdds([1, 2, 34, 3, 4, 5, 7, 23, 12]);
            // Intersection_of_Two_Arrays_II_350.Intersect([4, 9, 5], [9, 4, 9, 8, 4]);
            // Minimum_Difference_Between_Largest_and_Smallest_Value_in_Three_Moves_1509.MinDifference([1, 5, 0, 10, 14]);
            // Merge_Nodes_in_Between_Zeros_2181.MergeNodes(Merge_Nodes_in_Between_Zeros_2181.PrepareData());
            // Pass_the_Pillow_2582.PassThePillow(4, 5);
            // Water_Bottles_1518.NumWaterBottles(15, 4);
            // Find_the_Winner_of_the_Circular_Game_1823.FindTheWinner(5, 2);
            // Average_Waiting_Time_1701.AverageWaitingTime([[1, 2], [2, 5], [4, 3]]);
            // Crawler_Log_Folder_1598.MinOperations(["d1/", "d2/", "./", "d3/", "../", "d31/"]);
            // Lucky_Numbers_in_a_Matrix_1380.LuckyNumbers([[1, 10, 4, 2], [9, 3, 8, 7], [15, 16, 17, 12]]);
            // Sort_the_People_2418.SortPeople(["Mary", "John", "Emma"], [180, 165, 170]);
            // Sort_Array_by_Increasing_Frequency_1636.FrequencySort([-1, 1, -6, 4, 5, -6, 1, 4, 1]);
            // Sort_the_Jumbled_Numbers_2191.SortJumbled([8, 9, 4, 0, 2, 1, 3, 5, 7, 6], [991, 338, 38]);
            // Minimum_Cost_to_Convert_String_I_2976.MinimumCost("abcd", "acbe", ['a', 'b', 'c', 'c', 'e', 'd'], ['b', 'c', 'b', 'e', 'b', 'e'], [2, 5, 5, 1, 2, 20]);
            // Count_Number_of_Teams_1395.NumTeams([2, 5, 3, 4, 1]);
            // Minimum_Deletions_to_Make_String_Balanced_1653.MinimumDeletions("aababbab");
            // Kth_Distinct_String_in_an_Array_2053.KthDistinct(["a","b","a"], 3);
            // Minimum_Number_of_Pushes_to_Type_Word_II_3016.MinimumPushes("aabbccddeeffgghhiiiiii");
            // Spiral_Matrix_III_885.SpiralMatrixIII(1, 4, 0, 0);
            Kth_Largest_Element_in_a_Stream_703.Run();
        }
    }
}