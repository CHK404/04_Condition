using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_04_condition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //#region 이란
            //ㄴ VS 특정 코드 블록을 접어서 숨기게 만들어주는 기능
            //ㄴ #endregion으로 꼭 닫아주기

            #region #1 if문 강의
            int inputNum = 10;

            if(inputNum > 20)
            {
                //inputNum은 20보다 크지 않음 -> false
            }
            else if (inputNum < 5) 
            {
                //inputNum은 20보다 크지 않고, 5보다 작지 않음 -> false
            }
            else if (inputNum == 8)
            {
                //inputNum은 20보다 크지 않고, 5보다 작지 않으며 8도 아님 -> false
            }
            else
            {
                //위 조건이 모두 false 이므로 -> true
            }

            //조건과 조건을 비교하는 연산 수행
            bool is_true = inputNum == 10; //true

            //(조건1) or (조건2)
            //단축평가 통해
            bool compared = (inputNum > 10 || inputNum < 5); // false

            #endregion

            #region #1-2 실습 if문)
            /*if (CoinMatch(true))
             *{
             *   textBox_result.Text = "승리";
             *}
             *else
             *{
             *   textBox_result.Text = "패배";
             */
            #endregion
        }
        #region #1-2 실습 if문에 사용되는 함수
        bool CoinMatch(bool type)
        {
            //난수를 생성하기 위한 클래스
            //ㄴ 기본적으로 현재 시간을 기준으로 시드 자동 생성
            Random randomObj = new Random();
            /*
             * Random: 클래스
             * new Random(): Random이라는 클래스를 이용해서 'randomObj'라는 객체를 만든 것
             * randomObj: 객체
             */

            //짝수/홀수로 나눠서 0 혹은 1로 결정하게 하기
            int coin = randomObj.Next() % 2; //rnd.Next(): 0보다 크고 매우 큰 int값을 반환
            /* 
             * rnd.Next(): 0이상 int.MaxValue 미만 까지(약 21억)
             * rnd.Next(max): 0이상 max 미만
             * rnd.Next(min, max): min 이상 max 미만
             * rnd.NextDouble(): 0.0이상 1.0미만 소수를 랜덤 생성
             * -Random은 재사용이 좋다
             */

            /*
             * Math(=내장 클래스)
             * Math.Round(): 반올림
             * Math.Floor(): 내림
             * Math.Ceiling(): 올림
             */

            if((coin == 1 && type == true) || (coin == 0 && type == false)) 
            { 
                return true;
            }
            //1이면 앞면(true), 0이면 뒷면(false)
            //동전 결과(coin)와 사용자의 선택(type)이 일치할 경우에만 true 반환
            return false;   //false 반환: 이 함수의 결과가 일치 x, else 사용해도 무방
            #endregion
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_input_Click(object sender, EventArgs e)
        {
            if ((textBox_input.Text == "true") && (CoinMatch(true)))
            {
                textBox_result.Text = "입력하신 값은 true입니다\r\n동전 던지기 결과..\r\n승리";
            }
            else if ((textBox_input.Text == "false") && (CoinMatch(true)))
            {
                textBox_result.Text = "입력하신 값은 false입니다\r\n동전 던지기 결과..\r\n패배";
            }
            else if ((textBox_input.Text == "false") && (CoinMatch(false)))
            {
                textBox_result.Text = "입력하신 값은 false입니다\r\n동전 던지기 결과..\r\n승리";
            }
            else if ((textBox_input.Text == "true") && (CoinMatch(false)))
            {
                textBox_result.Text = "입력하신 값은 true입니다\r\n동전 던지기 결과..\r\n패배";
            }
            else
            {
                textBox_result.Text = "잘못된 입력입니다. 다시 입력해주세요.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (tButton.Checked == true)
            {
                textBox_input.Text = "true";
            } else if (fButton.Checked == true)
            {
                textBox_input.Text = "false";
            }

        }
    }
}
