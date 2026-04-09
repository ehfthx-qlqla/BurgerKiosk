using System;
using System.Drawing;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 생성자에서 이벤트 연결을 확인할 수도 있지만, 
            // 가급적 디자인 보기(속성창)에서 이벤트를 연결하는 것이 안전합니다.
        }

        int totalCost = 0;

        // [핵심 추가] 모든 선택 변경 시 공통으로 호출될 업데이트 메서드
        private void UpdateOrderInfo()
        {
            totalCost = 0;
            lstOrder.Items.Clear();

            // 1. 버거 선택 확인 및 계산
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

            // 2. 추가 옵션 확인 및 계산
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

            // 3. 라벨 업데이트 (즉시 반영)
            if (totalCost > 0)
            {
                lblTotalCost.ForeColor = Color.Teal;
                lblTotalCost.Text = $"총 금액 : {totalCost:N0}원";
            }
            else
            {
                lblTotalCost.ForeColor = Color.Black;
                lblTotalCost.Text = "총 금액 : 0원";
            }
        }

        // 라디오 버튼이나 체크박스의 'CheckedChanged' 이벤트에 이 메서드들을 연결하세요.
        private void Menu_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderInfo();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 이제 주문 버튼은 '최종 확인' 용도가 됩니다.
            if (totalCost == 0)
            {
                lblTotalCost.ForeColor = Color.IndianRed;
                lblTotalCost.Text = "메뉴를 먼저 선택해주세요.";
            }
            else
            {
                MessageBox.Show($"주문이 완료되었습니다!\n결제 금액: {totalCost:N0}원");
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            // 모든 체크 해제 (이때 각 CheckedChanged 이벤트가 발생하며 자동으로 UpdateOrderInfo가 호출됨)
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

            ResetTabOrder();
            this.ActiveControl = lblAppName;
        }

        private void ResetTabOrder()
        {
            rdoHamBurger.TabStop = true;
            rdoBulgogiBurger.TabStop = true;
            rdoChickenBurger.TabStop = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTabOrder();
            this.ActiveControl = lblAppName;
            this.AcceptButton = btnOrder;
            this.CancelButton = btnInit;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            ResetTabOrder();
        }
    }
}