(1)"Programming Challenges" 
###########This repository covers 3 major programming challenges#################

#DecimalGroupedByCommas [Question1Folder]

`Devise a function that takes an input 'n' (integer) and returns a string that is the decimal representation of that number grouped by commas after every 3 digits. You CAN NOT solve the task using a built-in formatting function that can accomplish the whole task on its own.`

###Example Output

1 -> "1"
10 -> "10"
100 -> "100"
1000 -> "1,000"
10000 -> "10,000"
100000 -> "100,000"
1000000 -> "1,000,000"
35235235 -> "35,235,235"
###Assumptions From the instructions given, the following assumptions can be deducted from it:

0 <= n < 1000000000
###For example

var inputs = new List<int> { 1, 10, 100, 1000, 10000, 100000, 1000000, 35235235 };
 
 -----------------------------------------------------------------------------------------

(2)#Anagram [Question2Folder]

##Code Example ###Assignment Devise a function that gets one word as parameter and returns all the anagrams for it from the file wl.txt. You can not use permutations to generate the possible words.

###Example Output The anagram for "horse" given the current input file, should give:

['heros', 'horse', 'shore'] should return the following:

heros
horse
shore

-------------------------------------------------------------------------------------------------------------------------
(3)#OpposedValuesFromLeftToRight [Question3Folder] # An index of an array is any index of that array and the sum of the lower indexes value is equal to the sum of the higher indexes value. That means if "i" is called the equilibrium index of array arr, then i should be 0 =< i =<arr.Length and arr[0]+arr[1]+.....+arr[i-1] = arr[i+1]+arr[i+2]+....+arr[arr.Length-1]."

##Code Example ###Assignment Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index are equal to the sum of all the items to the right of the index.
###Example Output Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12] the output would be "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12
###Assumptions/Constraints From the instructions given, the following assumptions can be deducted from it:
Constraints: 0 <= N <= 100 000
If no index exists then output -1.

##License

Copyright©2019 Christian Ngubana
---------------------------------------------------------------------------------------------------------------------------------





-----------------------------------------------------------------------------------------------------------------------------------
