using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Model
{
    public class Px4Library
    {
        public static string getNextID(String currentID, string defaultID)
        {

            string lastID = "";
            string numZero = "";
            if (currentID != "")
            {

                int index = 0;

                for (int i = 0; i < currentID.Length; i++) // Kiểm tra xem trong id, nơi nào là chữ , nơi nào là số (Chỉ áp dụng cho chữ đứng đầu và liền kề nhau)
                {
                    var isNumeric = int.TryParse(currentID[i].ToString(), out int n);
                    if (isNumeric)
                    {
                        index = i; // thứ tự vị trí bắt đầu của số 
                        break;
                    }
                }
                string charID = currentID.Substring(0, index);  // cắt phần chữ ra

                int lenNum = currentID.Length - index; // Tính tổng các chữ số ở phần số, ví dụ ID0001 cắt từ vị trí 3 đến  => 6(Tổng) - 2(phần chữ bị bỏ) = 4 số, 

                String numID = currentID.Substring(index, lenNum); // cắt phần số ra

                int nexNum = int.Parse(numID) + 1;



                // check xem sau khi convert về int và cộng, thì số đó bị mất bao nhiêu số 0 so với ban đầu
                // ví dụ ban đâu là 0004, chuyển về int + 1 = 5, thiếu 3 số 0 -> "000" + "5"
                for (int i = 0; i < (lenNum - nexNum.ToString().Length); i++)
                {
                    numZero = numZero + "0";
                }

                lastID = charID + numZero + nexNum.ToString(); // chữ + số 0 thiếu +  số thứ tự tiếp theo

            }
            else
            {
                lastID = defaultID;
            }

            return lastID;
        }

    }


}
