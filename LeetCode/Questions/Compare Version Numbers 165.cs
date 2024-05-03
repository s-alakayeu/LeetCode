namespace LeetCode.Questions;

public static class Compare_Version_Numbers_165
{
    public static int CompareVersion(string version1, string version2) {
        var versionOnePointer = 0;
        var versionTwoPointer = 0;

        while(!(versionOnePointer == version1.Length && versionTwoPointer == version2.Length))
        {
            var versionOne = 0;

            for(;versionOnePointer < version1.Length; versionOnePointer++)
            {
                if (version1[versionOnePointer] == '.')
                {
                    versionOnePointer++;
                    
                    break;
                }

                if (version1[versionOnePointer] == '0' && versionOne != 0)
                {
                    versionOne *= 10;
                }
                else if (versionOne == 0)
                {
                    versionOne = Convert.ToInt32(version1[versionOnePointer]) - 48;
                }
                else
                {
                    versionOne = versionOne * 10 + (Convert.ToInt32(version1[versionOnePointer]) - 48);
                }
            }

            var versionTwo = 0;

            for(;versionTwoPointer < version2.Length; versionTwoPointer++)
            {
                if (version2[versionTwoPointer] == '.')
                {
                    versionTwoPointer++;
                    
                    break;
                }

                if (version2[versionTwoPointer] == '0' && versionTwo != 0)
                {
                    versionTwo *=10;
                }
                else if (versionTwo == 0)
                {
                    versionTwo = Convert.ToInt32(version2[versionTwoPointer]) - 48;
                }
                else
                {
                    versionTwo = versionTwo * 10 + (Convert.ToInt32(version2[versionTwoPointer]) - 48);
                }
            }

            if (versionOne != versionTwo)
            {
                return versionOne < versionTwo ? -1 : 1;
            }
        }

        return 0;
    }
}