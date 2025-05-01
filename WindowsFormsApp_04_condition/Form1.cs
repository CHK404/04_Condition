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
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
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

            #region goto 점프문
            /*
             * goto
             * ㄴ 특정한 라벨로 점프해서 코드를 실행하도록 하는 명령문(제어문)
             * ㄴ 코드 순서를 무시하고 지정한 위치로 순간이동함
             * ㄴ 되도록 사용 권장 x
             * ㄴ 특정 상황에서 빠르게 탈출, 중첩 반복문 빠져나갈 때 사용
             * - 가독성 저하/ 유지보수 어려움/ 코드 흐름에 혼란
             */

            int selection = 0;
            textBox_print.Text += "Start \r\n";

        //#2 이동할 어딘가에 라벨 생성
        //ㄴ 라벨이름:
        //ㄴ 변수처럼 지정 가능(아무거나)
        Location:
            textBox_print.Text += "Location \r\n";

            if (selection == 0)
            {
                textBox_print.Text += "if문 안\r\n";

                selection = 1;
                //#1 goto 라벨이름;
                goto Location;
            }

            //goto & switch
            //switch문에서 goto case를 쓰는 목적?
            //ㄴ 여러 case에서 같은 코드를 실행해야 할 때, 중복 없이 깔끔하게 처리 가능

            CoffeeMenu choice = CoffeeMenu.WithIceCream; //2

            switch (choice)
            {
                case CoffeeMenu.Plain:
                    textBox_print.Text += "Coffee";
                    break;
                case CoffeeMenu.WithMilk:
                    textBox_print.Text += "Milk-";
                    goto case CoffeeMenu.Plain;
                case CoffeeMenu.WithIceCream:
                    textBox_print.Text += "IceCream-";
                    goto case CoffeeMenu.Plain;
            }
            //IceCream-Coffee
        }

            enum CoffeeMenu
            {
                Plain,
                WithMilk,
                WithIceCream
            }

            #endregion
        
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ins = textBox_input2.Text;

            if (Enum.TryParse(ins, true, out Days pickD))
            {
                switch (pickD)
                {
                    case Days.Monday:
                        textBox_output.Text = "월";
                        break;
                    case Days.Tuesday:
                        textBox_output.Text = "화";
                        break;
                    case Days.Wednesday:
                        textBox_output.Text = "수";
                        break;
                    case Days.Thursday:
                        textBox_output.Text = "목";
                        break;
                    case Days.Friday:
                        textBox_output.Text = "금";
                        break;
                    case Days.Saturday:
                        textBox_output.Text = "토";
                        break;
                    case Days.Sunday:
                        textBox_output.Text = "일";
                        break;
                }
            }
            else
            {
                textBox_output.Text = "???";
            }
        }
    }
}
