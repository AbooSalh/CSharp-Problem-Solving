//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSPS.Problems
//{

//    public class ListNode (int val = 0, ListNode next = null)
//    {
//        public int val = val;
//        public ListNode next = next;
//    }

//    internal class Add_Two_Numbers : IProblem
//    {
//        public string Result { 
//            get
//            {
//                var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
//                var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
//                var result = AddTwoNumbers(l1, l2);
//                var sb = new StringBuilder();
//                while (result != null)
//                {
//                    sb.Append(result.val);
//                    result = result.next;
//                }
//                return sb.ToString();
//            }
//        }
//        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
//        {
//            ListNode dummy = new();
//            ListNode current = dummy;
//            int carry = 0;

//            while (l1 != null || l2 != null || carry > 0)
//            {
//                int sum = carry;

//                if (l1 != null)
//                {
//                    sum += l1.val;
//                    l1 = l1.next;
//                }

//                if (l2 != null)
//                {
//                    sum += l2.val;
//                    l2 = l2.next;
//                }

//                carry = sum / 10;
//                current.next = new ListNode(sum % 10);
//                current = current.next;
//            }

//            return dummy.next;            
//        }

//    }
//}
