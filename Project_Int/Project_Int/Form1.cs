﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Int
{

    public partial class Form : System.Windows.Forms.Form
    {

        //string forimg = "1-2.jpeg";
        string[][] forimg = { 
            new[] { "2-1.jpg", "3-1.jpg", "6-1.jpg", "7-1.jpg" },
            new[] {  "9-1.jpeg", "10-1.jpeg", "11-1.jpeg", "12-1.jpeg" },
        };
        string[][] forname = {
            new[] { "Here Comes the Sun", "La Vie En Rose", "Always on my Mind", "Love Out Loud" },
            new[] {  "The Marilyng", "Imagine", "Lava Passion", "Grace Kelly" }
        };
        string[][][] fordetail = {
            new[] { 
                new[] { "Here Comes the Sun", "การผสมผสานอย่างลงตัวระหว่างดอกทานตะวันและกุหลาบสีส้ม", "ไล่ท้องฟ้าอันอึมครึมออกและต้อนรับแสงแดดอันสดใสด้วยช่อดอกไม้อันสะดุดตาและมีชีวิตชีวาช่อนี้ ดอกทานตะวันสีจะช่วยเยียวยาวันอันมืดมน ช่อดอกช่อนี้ถูกโรยหน้าด้วยดอกกุหลาบสีส้มซึ่งแสดงมีความหมายของคุณค่าของชีวิตและการสนับสนุนค้ำจุน เหมือนกับเพลงจาก The Beatles ช่อดอกไม้ Here Comes the Sun นั้นมีความสดใส คลาสสิกอยู่ในตัว เช่นเดียวกับทำนองเพลง ดอกทานตะวันสีทองนั้นมีชีวิตชีวา สดใสและสร้างรอยยิ้มให้กับทุกคน โดยดอกขนาดใหญ่ของทานจะวันจะหันไปเข้าหาแสงอาทิตย์เสมอ เพราะฉะนั้นคุณต้องวางดอกทานตะวันไว้ในห้องหรือสถานที่ที่มีแสดงแดดเพียงพอ" },
                new[] { "La Vie En Rose", "ช่อดอกกุหลาบสีชมพูสุดคลาสสิค", "ไม่จําเป็นต้องเอ่ยคำพูดอื่นใดเวลาที่คุณมอบช่อกุหลาบสีชมพูอันโดดเด่นและสวยงามช่อนี้ ไม่ว่าคุณจะชอบเพลงต้นฉบับของ Edith Piaf หรือเวอร์ชั่นฮิตยอดนิยมของ Louis Armstrong เพลงสุดคลาสสิคนี้ไม่เคยทำให้ต้องผิดหวัง La Vie En Rose คือช่อดอกไม้ที่เหมาะสมอย่างยิ่งสําหรับโอกาสสุดโรแมนติก เช่นเดียวกับเพลง La Vie En Rose เปรียบดั่งช่อดอกไม้ที่จะสร้างความทรงจำอันมีค่าให้กับคนพิเศษของคุณอย่างไม่มีวันลืม" },
                new[] { "คิดถึงคำนึงหา (ออลเวยส์ออนมายไมนด์)", "การผสมผสานที่งดงามและละเอียดอ่อนของสีขาว สีม่วงและดอกกุหลาบสีพีช", "“ออลเวยส์ออนมายไมนด์” เป็นการจัดวางในรูปทรงสไปรัล (ทรงเกลียว) ที่งดงามโดยการนำเสนอกุหลาบสีขาวและสีพีช เติมแต่งด้วยดอกกุหลาบพวงและใบยูคาลิปตัส เป็นการจัดวางที่นำเสนอความสง่างามและโรแมนติกทำให้เหมาะสมกับโอกาสโรแมนติกต่างๆ หรือสามารถเป็นของขวัญวันแม่ ของขวัญแทนความคิดถึง หรือแทนคำขอบคุณก็เป็นได้" },
                new[] { "Love Out Loud รัก ดังๆ!", "มาร่วมฉลองเดือนแห่งการโอบกอดทุกตัวตนกับ “Love Out Loud”", "สดใส และฟุ้งไปด้วยสีสันแห่งความรัก ช่อดอกไม้พิเศษนี้รังสรรค์จากแนวความคิดของการเฉลิมฉลองให้กับความหลากหลาย การยอมรับในทุกเฉดสีของผู้คนในสังคม มาพร้อมกับสีสันที่สดใสแรงกล้า สื่อถึงการแสดงออกของความรักในทุกรูปแบบ มาเป็นส่วนหนึ่งของความหลากหลาย มาสร้างความเปิดกว้างและความรักที่ไร้ขีดจำกัดไปกับเรา" },
            },
            new[] { 
                new[] { "Like a Virgin", "The perfect mix of time By combining white from Miranda and English roses. Decorate with white anemone flowers", "Like a Virgin is a bouquet that conveys luxury and modernity. Designed based on the lyrics to the song “Like a Virgin” sung by Madonna, which was a hit in the 80s.\r\n\r\nThis bouquet is designed to bring out the outstanding identity of Urban Flower Used in a spiral pattern (spiral shape), attracting attention and eye-catching with imported premium-grade white flowers such as Miranda roses and anemone flowers. Like a “like a virgin” union of branches, this layout is modern and can be used for almost any occasion. especially as an anniversary gift" },
                new[] { "อิเมจิน (จินตนาการ)", "การประสานกันอย่างโดดเด่นด้วยสีแดง\nจากดอกกุหลาบเอกวาดอร์และสีขาวอมเหลืองจากลิลลี่", "‘You may say I’m a dreamer But I’m not the only one’(คุณบอกว่าฉันเป็นคนเพ้อฝัน แต่ฉันไม่ได้เป็นแบบนี้คนเดียว) บทความข้างต้นเป็นส่วนหนึ่งในเนื้อร้องของบทเพลงที่มีชื่อว่า “อิเมจิน”ขับร้องเเละมีความเป็นอมตะมาจนถึงปัญจุบัน ช่อดอกไม้ช่อนี้ได้หยิบยืมความหมายของเนื้อเพลงมานำเสนอผ่านการจัดวางเเบบสไปรัล(ทรงเกลียว)ที่เต็มไปด้วยความงดงามที่สื่อถึงการเคลื่อนไหลทางความคิดเเละจินตนาการของมนุษย์ โดดเด่นไปด้วยสีเเดงเเละทีขาวอมเหลือง ซึ่งใช้วัตถุดิบนำเข้าเกรดพรีเมียมอย่างดอกกุหลาบเอกวาดอร์เเละลิลลี่ที่ดูหรูหรา ดอกไม้ช่อนี้เปรียบเสมือนคนช่างฝันไม่เพียงดูสง่า อีกทั่งยังมีความน่าหลงไหล เมาะสำหรับใช้เป็นของขวัญในหลากหลายโอกาส โดยเฉพาะสิ่งเเทนใจในวันครบรอบ" },
                new[] { "ลาวาแพชชั่น", "การรวมตัวที่เราร้อนระหว่างดอกกุหลาบเอกวาดอร์ ดอกเรนันคูลัส และดอกทานตะวัน", "“ลาวาแพชชั่น” เป็นการออกแบบโดยการนำเอาสีโทนร้อนของดอกไม้มาผสมผสานกัน นำเสนอความร้อนแรงที่น่าหลงใหล ช่อดอกไม้นี้จัดวางด้วยลักษณะรูปเเบบทรงสไปรัล (ทรงเกลียว) สร้างความโดดเด่นด้วยดอกกุหลาบสีแดง ประกอบกับดอกเรนันคูลัสสีแดงและสีส้ม เสริมด้วยดอกคาลล่าลิลลี่สีแดง ดอกไม้ช่อนี้จึงเต็มไปด้วยเร่าร้อนเเละสุดโรเเมนติก เหมาะสำหรับการเฉลิมฉลองและวันเกิด" },
                new[] { "Grace Kelly", "ความสง่างามของดอกกุหลาบนานาชนิด", "ช่อดอกไม้คลาสสิกนี้เพอร์เฟคที่สุดสำหรับหญิงอันงดงามในชีวิตของคุณ การผสมผสานกันระหว่างดอกกุหลาบสีชมพูและสีพีชชวนให้นึกถึงความงดงามและความสง่างามของนักแสดงชาวอเมริกันสุดคลาสสิกอย่าง Grace Kelly ได้อย่างสมบูรณ์แบบ กุหลาบสีชมพูเป็นสัญลักษณ์แห่งความอ่อนช้อยและความงาม ในขณะที่ดอกกุหลาบสีพีชเป็นสัญลักษณ์แห่งความจริงใจ เพราะฉะนั้นแล้วการมอบช่อดอกไม้ช่อนี้ในกับคนพิเศษของคุณถือเป็นวิธีที่ดีที่สุดที่จะทำให้เค้ารับรู้ถึงความรู้สึกที่แท้จริงของคุณ เหมือนกับ  Grace Kelly คนรักของคุณจะล่องลอยไปกับสายลมเมื่อได้รับช่อดอกไม่ช่อนี้" }}
        };

        int CountPage, indexselect;
        double numberCal;

        private void dataFlower(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, "img", forimg[CountPage][0]);
            pictureBox2.ImageLocation = Path.Combine(Application.StartupPath, "img", forimg[CountPage][1]);
            pictureBox3.ImageLocation = Path.Combine(Application.StartupPath, "img", forimg[CountPage][2]);
            pictureBox4.ImageLocation = Path.Combine(Application.StartupPath, "img", forimg[CountPage][3]);
            nameflower1.Text = forname[CountPage][0];
            nameflower2.Text = forname[CountPage][1];
            nameflower3.Text = forname[CountPage][2];
            nameflower4.Text = forname[CountPage][3];
        }

        private void dataDetail(object sender, EventArgs e)
        {
            Flowers.TabPages.Add(tabPage3);

            Flowers.SelectedTab = Flowers.TabPages[3];

            detailImg.ImageLocation = Path.Combine(Application.StartupPath, "img", forimg[CountPage][indexselect]);
            head.Text = forname[CountPage][indexselect];
            detailHead.Text = fordetail[CountPage][indexselect][0];
            subHead.Text = fordetail[CountPage][indexselect][1];
            detail.Text = fordetail[CountPage][indexselect][2];
        }

        private void calChange(object sender, EventArgs e)
        {
            double waitNum1, waitNum2, waitNum3, waitNum4, totalPrice = 0;
            if (double.TryParse(numberCal1.Text, out numberCal)) totalPrice += numberCal;
            if (double.TryParse(numberCal2.Text, out numberCal)) totalPrice += numberCal;
            if (double.TryParse(numberCal3.Text, out numberCal)) totalPrice += numberCal;
            if (double.TryParse(numberCal4.Text, out numberCal)) totalPrice += numberCal;
            numTotalPrice.Text = totalPrice.ToString();

        }

        public Form()

        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Flowers.TabPages.Remove(tabPage3);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            Flowers.TabPages.Remove(tabPage3);
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            Flowers.TabPages.Remove(tabPage3);
            CountPage = 0;
            btn_reduce.Hide();
            btn_increase.Show();
            dataFlower(sender,e);
            
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            CountPage++;
            dataFlower(sender, e);
            if (CountPage != 0) {
             btn_reduce.Show();
             btn_increase.Hide();
            }
        }

        private void btn_reduce_Click(object sender, EventArgs e)
        {
            CountPage--;
            dataFlower(sender, e);
            if (CountPage == 0){
             btn_reduce.Hide();
             btn_increase.Show();
            }

        }

        //คำนวณเงิน
        private void button8_Click(object sender, EventArgs e)
        {
            double total;
            if (numberCal1.Text == "")
            {
                MessageBox.Show("กรุณากรอกจำนวนเงินของสินค้ารายการที่ 1");
                numberCal1.Focus();
            } else if (numberCal2.Text == "")
            {
                MessageBox.Show("กรุณากรอกจำนวนเงินของสินค้ารายการที่ 2");
                numberCal2.Focus();
            }
            else if (numberCal3.Text == "")
            {
                MessageBox.Show("กรุณากรอกจำนวนเงินของสินค้ารายการที่ 3");
                numberCal3.Focus();
            }
            else if (numberCal4.Text == "")
            {
                MessageBox.Show("กรุณากรอกจำนวนเงินของสินค้ารายการที่ 4");
                numberCal4.Focus();
            }
            else if (!double.TryParse(numberCal1.Text, out numberCal)
                || !double.TryParse(numberCal2.Text, out numberCal)
                || !double.TryParse(numberCal3.Text, out numberCal)
                || !double.TryParse(numberCal4.Text, out numberCal))
            {
                MessageBox.Show("กรุณากรอกตัวเลขเท่านั้น");
            }
            else {
                double vat;
                total = double.Parse(numberCal1.Text) + double.Parse(numberCal2.Text) + double.Parse(numberCal3.Text) + double.Parse(numberCal4.Text);
                double lastTotal;
                if (discount.Checked)
                {
                double discountNumber = total * 0.1;
                vat = (total - discountNumber) * 0.07;
                lastTotal = total - discountNumber + vat;
                MessageBox.Show("ราคารวม\t\t\t:\t" + total.ToString()
                + "\tบาท\nส่วนลดจากทางร้าน 10%\t:\t" + discountNumber.ToString()
                + "\tบาท\nVat 7%\t\t\t:\t" + vat.ToString()
                + "\tบาท\nยอดชำระรวมทั้งสิ้น\t\t:\t" + lastTotal.ToString()+ "\tบาท");
                }
                else
                {
                vat = total * 0.07;
                lastTotal = total + vat;
                MessageBox.Show("ราคารวม\t\t\t:\t" + total.ToString()
                + "\tบาท\nVat 7%\t\t\t:\t" + vat.ToString()
                + "\tบาท\nยอดชำระรวมทั้งสิ้น\t\t:\t" + lastTotal.ToString() + "\tบาท");
                }
            }
        
        }

        //เรียกหน้ารายละเอียด
        private void nameflower1_Click(object sender, EventArgs e)
        {
            indexselect = 0;
            dataDetail(sender, e);
        }

        private void nameflower2_Click(object sender, EventArgs e)
        {
            indexselect = 1;
            dataDetail(sender, e);
        }
        private void nameflower3_Click(object sender, EventArgs e)
        {
            indexselect = 2;
            dataDetail(sender, e);
        }
        private void nameflower4_Click(object sender, EventArgs e)
        {
            indexselect = 3;
            dataDetail(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            indexselect = 0;
            dataDetail(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            indexselect = 1;
            dataDetail(sender, e);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            indexselect = 2;
            dataDetail(sender, e);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            indexselect = 3;
            dataDetail(sender, e);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void head_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void numberCal1_TextChanged(object sender, EventArgs e)
        {
            calChange(sender, e);
        }

        private void numberCal2_TextChanged(object sender, EventArgs e)
        {
            calChange(sender, e);
        }

        private void numberCal3_TextChanged(object sender, EventArgs e)
        {
            calChange(sender, e);
        }

        private void numberCal4_TextChanged(object sender, EventArgs e)
        {
            calChange(sender, e);
        }

        private void discount_CheckedChanged(object sender, EventArgs e)
        {
            double foroutput;
            if (discount.Checked)
            {
                if (double.TryParse(numTotalPrice.Text, out numberCal))
                {
                    foroutput = numberCal * 0.9;
                    numTotalPrice.Text = foroutput.ToString();
                }
            }
            else
            {
                if (double.TryParse(numTotalPrice.Text, out numberCal))
                {
                    foroutput = numberCal * 100/90;
                    numTotalPrice.Text = foroutput.ToString();
                }
            }
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void numberCal1_Click(object sender, EventArgs e)
        {
           if (!double.TryParse(numberCal1.Text, out numberCal)) numberCal1.Clear();
            numberCal1.Focus();
        }

        private void numberCal2_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(numberCal2.Text, out numberCal)) numberCal2.Clear();
        }

        private void numberCal3_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(numberCal3.Text, out numberCal)) numberCal3.Clear();
 
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void numberCal4_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(numberCal4.Text, out numberCal)) numberCal4.Clear();
        }
    }
    }