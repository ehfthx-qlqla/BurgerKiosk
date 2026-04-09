using System.Reflection.Emit;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int totalCost = 0;
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //메뉴선택
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            //추가옵션
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }
            lblTotalCost.Text = $"총 금액 : {totalCost:N0}원";

            //에러메시지
            // 1. 버거 선택 여부 확인 (라디오 버튼 중 하나라도 체크되었는지)
            if (rdoHamBurger.Checked == false && rdoBulgogiBurger.Checked == false && rdoChickenBurger.Checked == false)
            {
                // 아무것도 선택되지 않은 경우
                lblTotalCost.ForeColor = Color.IndianRed; // 에러 강조를 위해 빨간색으로 변경
                lblTotalCost.Text = "메뉴를 선택해주세요.";
            }
            else
            {
                // 정상적으로 선택된 경우 (여기에 주문 처리 로직 작성)
                lblTotalCost.ForeColor = Color.Teal;
                // 원래 색상(이미지상의 청록색 계열)으로 복구
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // 화면이 완전히 뜬 직후에 체크를 강제로 해제
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
        }
    }
}
