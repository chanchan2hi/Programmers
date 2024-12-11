using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 기초 -공배수
//num이 n,m의 배수이면 1,아니면0 
namespace Programmers.Properties
{
    public class Solution {
        public int solution(int number, int n, int m) {
            int answer = 0;
            if ((number % n == 0) && (number % m == 0)) return 1;
            else return 0;
        }
    }
