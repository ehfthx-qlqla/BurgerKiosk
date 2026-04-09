using System;
using System.Drawing;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public void ResetTabOrder()
        {
            // 모든 라디오 버튼의 체크를 해제하면 탭 포커스가 사라질 수 있음
            // 따라서 첫 번째 버튼에 TabStop을 강제로 부여하여 탭 시작점을 고정합니다.
            rdoHamBurger.TabStop = true;
            rdoBulgogiBurger.TabStop = true;
            rdoChickenBurger.TabStop = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        int totalCost = 0;

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 주문 버튼 클릭 시 금액 누적 방지 (초기화)
            totalCost = 0;
            lstOrder.Items.Clear();

            // 버거 선택 여부 확인
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.IndianRed;
                lblTotalCost.Text = "메뉴를 선택해주세요.";
                return; // 선택 안 됐으면 중단
            }

            // 메뉴 선택 로직
            if (rdoHamBurger.Checked) { totalCost += 5000; lstOrder.Items.Add("햄버거 5,000원"); }
            else if (rdoBulgogiBurger.Checked) { totalCost += 4000; lstOrder.Items.Add("불고기버거 4,000원"); }
            else if (rdoChickenBurger.Checked) { totalCost += 3000; lstOrder.Items.Add("치킨버거 3,000원"); }

            // 추가 옵션
            if (chkPotato.Checked) { totalCost += 3500; lstOrder.Items.Add("감자튀김 3,500원"); }
            if (chkCola.Checked) { totalCost += 2500; lstOrder.Items.Add("콜라 2,500원"); }
            if (chkCheese.Checked) { totalCost += 1500; lstOrder.Items.Add("치즈 추가 1,500원"); }
            if (chkSauce.Checked) { totalCost += 500; lstOrder.Items.Add("소스 추가 500원"); }

            lblTotalCost.ForeColor = Color.Teal;
            lblTotalCost.Text = $"총 금액 : {totalCost:N0}원";
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            totalCost = 0;

            // 모든 체크 해제
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
            lblTotalCost.ForeColor = Color.Black;

            // [추가] 초기화 시 탭 순서가 꼬이지 않도록 다시 설정
            ResetTabOrder();

            // 포커스를 라벨로 보내 점선 숨기기
            this.ActiveControl = lblAppName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기 로딩 시 설정
            ResetTabOrder();
            this.ActiveControl = lblAppName;
            this.AcceptButton = btnOrder;
            this.CancelButton = btnInit;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // 화면 출력 후 다시 한번 체크 해제 확인 및 탭 설정
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            ResetTabOrder();
        }
    }
}