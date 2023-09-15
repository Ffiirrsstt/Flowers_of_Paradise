using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Int
{

    public partial class Form : System.Windows.Forms.Form
    {

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

        List<List<string>> dataSignUp = new List<List<string>>();
        Boolean userRepeat, passwordConfirmOk, previewCard;
        int CountPage, indexselect, countEyePassSignUp, countEyePassConSignUp, countEyePassSignIn;
        int indexGender=3, indexStatus=2, indexSV;
        string nameFDataMemberCard = "ชื่อ ", nameSDataMemberCard = "นามสกุล ", genderDataMemberCard = "เพศ ไม่ระบุ", statusDataMemberCard = "สถานภาพ ไม่ระบุ", SVDataMemberCard = "";
        double numberCal;

        //การแสดงผลบัตรสมาชิกในรูปแบบที่แสดงผลของข้อมูลที่ถูกบันทึกเอาไว้แล้ว
        private void dataMemberSave(object sender, EventArgs e)
        {
            if (!previewCard)
            {
                nameFMemberCard.Text = nameFDataMemberCard;
                nameSMemberCard.Text = nameSDataMemberCard;
                genderMemberCard.Text = genderDataMemberCard;
                statusMemberCard.Text = statusDataMemberCard;
            }
        }

        //save
        private string funGender(object sender, EventArgs e)
        {
            string forstr = "เพศ ";
            if (female.Checked)
                forstr += female.Text;
            else if (male.Checked)
                forstr += male.Text;
            else if (lgbt.Checked)
                forstr += lgbt.Text;
            else
                forstr += notSPGender.Text;
            return forstr;
        }

        private string funStatus(object sender, EventArgs e)
        {
            string forstr = "สถานภาพ ";
            if (single.Checked)
                forstr += single.Text;
            else if (marry.Checked)
                forstr += marry.Text;
            else if (notSPStatus.Checked)
                forstr += notSPStatus.Text;
            else
            {
                if (otherStatus.Checked)
                    forstr += funotherStatus(sender,e);
                else
                    forstr += otherforStatus.Text;
            }
            return forstr;
        }

        private void funSave(object sender, EventArgs e)
        {
            nameFDataMemberCard = funMemder(sender, e, nameFDataMemberCard, nameFMember.Text, "ชื่อ", 10, 9);
            nameSDataMemberCard = funMemder(sender, e, nameSDataMemberCard, nameSMember.Text, "นามสกุล", 6, 5);
            genderDataMemberCard = funGender(sender, e);
            statusDataMemberCard = funStatus(sender, e);
            SVDataMemberCard = changeSV(sender, e);
        }

        //บัตรสมาชิก
        //ชื่อจริงและนามสกุล
        //จำกัดการแสดงผลอักษรบนบัตรสมาชิก
        private string funMemder(object sender, EventArgs e, string forDataOutput, string forDataInput, string forstr, int quantity, int amount)
        {
            string result = forDataOutput;
            if (!(forDataInput == ""))
            {
                if (forDataInput.Length <= quantity)
                    result = forstr + " " + forDataInput;
                else
                    result = forstr + " " + forDataInput.Substring(0, amount) + "...";
            }
            return result;
        }

        //เพศ
        private void changeGender(object sender, EventArgs e, string forData)
        {
            genderMemberCard.Text = "เพศ " + forData;
        }


        //สถานะภาพ
        private void changeStatus(object sender, EventArgs e, string forData)
        {
            statusMemberCard.Text = "สถานภาพ " + forData;
        }
        private string funotherStatus(object sender, EventArgs e)
        {
            string forstr;
            if (otherforStatus.Text != "")
                forstr = funMemder(sender, e, "", otherforStatus.Text, "", 4, 3);
            else
                forstr = "กำลังรอการระบุสถานภาพ";
            return forstr;
        }

        //บริการพิเศษ
        private string changeSV(object sender, EventArgs e)
        {
            string forstr;
            if (card.Checked || consult.Checked || otherSV.Checked)
            {
                forstr = "ความต้องการบริการพิเศษ";
                if (card.Checked)
                    forstr += "\n- " + card.Text;
                if (consult.Checked)
                    forstr += "\n- " + consult.Text;
                if (otherSV.Checked)
                    forstr += "\n-" + funMemder(sender, e, " กำลังรอการระบุความต้องการบริการพิเศษที่ลูกค้าต้องการเพิ่มเติม..."
                        , otherforSV.Text, "", 40, 39);
            }
            else forstr = "";
            return forstr;
        }

        private void callchangeSV(object sender, EventArgs e)
        {
            service.Text = changeSV(sender, e);
        }



        //การเรียกหน้าต่างล็อกอินและหน้าต่างลงทะเบียน
        private void callWindowIn(object sender, EventArgs e)
        {
            Flowers.TabPages.Add(windowSignIn);
            basicSignIn(sender, e);
        }
        private void callWindowUp(object sender, EventArgs e)
        {
            Flowers.TabPages.Add(windowSignUp);
            basicSignUp(sender, e);
        }

        //การลงทะเบียน
        private void checkNameRepeat(object sender, EventArgs e)
        {
            userRepeat = false;
            foreach (List<string> checkUser in dataSignUp)
            {
                if (checkUser[0] == newUser.Text)
                {
                    userRepeat = true;
                    break;
                }
            }
        }

        private void checkPassword(object sender, EventArgs e)
        {
            passwordConfirmOk = (passwordSignUp.Text == passwordConSignUp.Text);
            if (!passwordConfirmOk)
                textDesConfirm.Text = "รหัสผ่านกับรหัสยืนยันไม่ตรงกัน";
            else textDesConfirm.Text = "";
            if (passwordConSignUp.Text == "")
                textDesConfirm.Text = "";
        }

        //การซ่อนสลับกับเปิดรหัสผ่านให้สามารถอ่านได้
        private void checkEye(object sender, EventArgs e, string selectData)
        {
            string dataPathEye, dataPathEyeHide;
            dataPathEye = Application.StartupPath + "\\img\\eye.jpg";
            dataPathEyeHide = Application.StartupPath + "\\img\\eyehide.jpg";
            if (selectData == "signUp")
            {
                if (countEyePassSignUp % 2 == 0)
                {
                    passwordSignUp.PasswordChar = '*';
                    eyePassSignUp.ImageLocation = dataPathEye;
                }
                else
                {
                    passwordSignUp.PasswordChar = '\0';
                    eyePassSignUp.ImageLocation = dataPathEyeHide;
                }
                countEyePassSignUp++;
            }
            else if (selectData == "confirmSignUp")
            {
                if (countEyePassConSignUp % 2 == 0)
                {
                    passwordConSignUp.PasswordChar = '*';
                    eyeConfirmPass.ImageLocation = dataPathEye;
                }
                else
                {
                    passwordConSignUp.PasswordChar = '\0';
                    eyeConfirmPass.ImageLocation = dataPathEyeHide;
                }
                countEyePassConSignUp++;
            }
            else
            {
                if (countEyePassSignIn % 2 == 0)
                {
                    password.PasswordChar = '*';
                    eyePassSignIn.ImageLocation = dataPathEye;
                }
                else
                {
                    password.PasswordChar = '\0';
                    eyePassSignIn.ImageLocation = dataPathEyeHide;
                }
                countEyePassSignIn++;
            }
        }

        private void basicSignIn(object sender, EventArgs e)
        {
            callWindow(sender, e);
            countEyePassSignIn = 0;
            user.Clear();
            password.Clear();
            checkEye(sender, e, "signIn");
            describesUser.Text = "";
            describesPassword.Text = "";
        }
        private void basicSignUp(object sender, EventArgs e)
        {
            callWindow(sender, e);
            countEyePassSignUp = 0;
            countEyePassConSignUp = 0;
            newUser.Clear();
            passwordSignUp.Clear();
            passwordConSignUp.Clear();
            checkEye(sender, e, "signUp");
            checkEye(sender, e, "confirmSignUp");
            textDesName.Text = "";
            textDesPassword.Text = "";
            textDesConfirm.Text = "";
        }

        //แสดงภาพในรูปภาพสำหรับหน้ารูปภาพและหนาล็อกอิน
        private void dataFlower(object sender, EventArgs e)
        {
            string[] forimgData = new string[4], fornameData = new string[4];
            for (int forcount = 0; forcount <= 3; forcount++)
            {
                forimgData[forcount] = Path.Combine(Application.StartupPath, "img", forimg[CountPage][forcount]);
                fornameData[forcount] = forname[CountPage][forcount];
            }
            //login
            imglog1.ImageLocation = forimgData[0];
            imglog2.ImageLocation = forimgData[1];
            imglog3.ImageLocation = forimgData[2];
            imglog4.ImageLocation = forimgData[3];
            nameflowerlog1.Text = fornameData[0];
            nameflowerlog2.Text = fornameData[1];
            nameflowerlog3.Text = fornameData[2];
            nameflowerlog4.Text = fornameData[3];
            //img
            img1.ImageLocation = forimgData[0];
            img2.ImageLocation = forimgData[1];
            img3.ImageLocation = forimgData[2];
            img4.ImageLocation = forimgData[3];
            nameflower1.Text = fornameData[0];
            nameflower2.Text = fornameData[1];
            nameflower3.Text = fornameData[2];
            nameflower4.Text = fornameData[3];
        }

        private void dataDetail(object sender, EventArgs e)
        {
            Flowers.TabPages.Add(detailPage);

            Flowers.SelectedTab = Flowers.TabPages[6];

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

        private void reduce(object sender, EventArgs e)
        {
            CountPage--;
            dataFlower(sender, e);
            if (CountPage == 0)
            {
                //login
                btnReduce.Hide();
                btnIncrease.Show();
                //img
                btn_reduce.Hide();
                btn_increase.Show();
            }

        }

        private void increase(object sender, EventArgs e)
        {
            CountPage++;
            dataFlower(sender, e);
            if (CountPage != 0)
            {
                //login
                btnReduce.Show();
                btnIncrease.Hide();
                //img
                btn_reduce.Show();
                btn_increase.Hide();
            }
        }

        private void imgset1(object sender, EventArgs e)
        {
            indexselect = 0;
            dataDetail(sender, e);
        }
        private void imgset2(object sender, EventArgs e)
        {
            indexselect = 1;
            dataDetail(sender, e);
        }
        private void imgset3(object sender, EventArgs e)
        {
            indexselect = 2;
            dataDetail(sender, e);
        }
        private void imgset4(object sender, EventArgs e)
        {
            indexselect = 3;
            dataDetail(sender, e);
        }

        private void loadImg(object sender, EventArgs e)
        {
            Flowers.TabPages.Remove(detailPage);
            CountPage = 0;
            dataFlower(sender, e);
            //login
            btnReduce.Hide();
            btnIncrease.Show();
            //img
            btn_reduce.Hide();
            btn_increase.Show();
        }

        private void defultRemoveTab(object sender, EventArgs e)
        {
            Flowers.TabPages.Remove(detailPage);
            Flowers.TabPages.Remove(windowSignIn);
            Flowers.TabPages.Remove(windowSignUp);
        }
        private void callWindow(object sender, EventArgs e)
        {
            Flowers.SelectedTab = Flowers.TabPages[6];
        }

        public Form()

        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            defultRemoveTab(sender, e);
            loadImg(sender, e);//ถ้าไม่ได้มีต้องการให้หน้าของสินค้าเริ่มต้นที่สินค้าชิ้นแรก แต่ถ้าต้องการให้เริ่มที่สินค้าชิ้นแรกให้ใส่ที่ tab แทน
            headSignUp.Text = "ลงทะเบียนสมาชิกเพื่อใช้บริการ\nFlowers of Paradise ID";
        }

        private void checkRadio(object sender, EventArgs e)
        {
            //เพศ
            if (indexGender == 0)
                female.Checked = true;
            else if (indexGender == 1)
                male.Checked = true;
            else if (indexGender == 2)
                lgbt.Checked = true;
            else
                notSPGender.Checked = true;

            //status
            if (indexStatus ==0)
                single.Checked = true;
            else if (indexStatus ==1)
                marry.Checked = true;
            else if (indexStatus ==2)
                notSPStatus.Checked = true;
            else
                otherStatus.Checked = true;
        }
        private void tabControl_Click(object sender, EventArgs e)
        {
            defultRemoveTab(sender, e);

            if (Flowers.SelectedTab == Flowers.TabPages[5])
            {
                nameFMember.Clear();
                nameSMember.Clear();
                previewCard = false;
                dataMemberSave(sender, e);
                previewCard = true;
                btnMemberTR.Hide();
                btnMemberBR.Hide();
                checkRadio(sender, e);
            }
        }

        //ปุ่มเปลี่ยนหน้าสำหรับรูปภาพ
        private void btn_increase_Click(object sender, EventArgs e)
        {
            increase(sender, e);
        }

        private void btn_reduce_Click(object sender, EventArgs e)
        {
            reduce(sender, e);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            increase(sender, e);
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            reduce(sender, e);
        }

        //เช็กค่าที่ได้รับในหน้าราคาสำหรับการคำนวณ
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

        private void numberCal4_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(numberCal4.Text, out numberCal)) numberCal4.Clear();
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
                    + "\tบาท\nยอดชำระรวมทั้งสิ้น\t\t:\t" + lastTotal.ToString() + "\tบาท");
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
                    foroutput = numberCal * 100 / 90;
                    numTotalPrice.Text = foroutput.ToString();
                }
            }
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

        //เรียกหน้ารายละเอียด
        private void imglogin1_Click(object sender, EventArgs e)
        {
            imgset1(sender, e);
        }

        private void imglog2_Click(object sender, EventArgs e)
        {
            imgset2(sender, e);
        }

        private void imglog3_Click(object sender, EventArgs e)
        {
            imgset3(sender, e);
        }

        private void imglog4_Click(object sender, EventArgs e)
        {
            imgset4(sender, e);
        }
        private void nameflowerlog1_Click(object sender, EventArgs e)
        {
            imgset1(sender, e);
        }

        private void nameflowerlog2_Click(object sender, EventArgs e)
        {
            imgset2(sender, e);
        }

        private void nameflowerlog3_Click(object sender, EventArgs e)
        {
            imgset3(sender, e);
        }

        private void nameflowerlog4_Click(object sender, EventArgs e)
        {
            imgset4(sender, e);
        }
        private void nameflower1_Click(object sender, EventArgs e)
        {
            imgset1(sender, e);
        }

        private void nameflower2_Click(object sender, EventArgs e)
        {
            imgset2(sender, e);
        }
        private void nameflower3_Click(object sender, EventArgs e)
        {
            imgset3(sender, e);
        }
        private void nameflower4_Click(object sender, EventArgs e)
        {
            imgset4(sender, e);
        }
        private void img1_Click(object sender, EventArgs e)
        {
            imgset1(sender, e);
        }

        private void img2_Click(object sender, EventArgs e)
        {
            imgset2(sender, e);
        }
        private void img3_Click(object sender, EventArgs e)
        {
            imgset3(sender, e);
        }

        private void img4_Click(object sender, EventArgs e)
        {
            imgset4(sender, e);
        }

        //การเรียกหน้าต่างล็อกอินและหน้าต่างลงทะเบียน
        private void btnLogin_Click(object sender, EventArgs e)
        {
            callWindowIn(sender, e);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            callWindowUp(sender, e);
        }

        //การเรียกใช้การซ่อนพาสเวิร์ด
        private void eyePassSignUp_Click(object sender, EventArgs e)
        {
            checkEye(sender, e, "signUp");
        }

        private void eyeConfirmPass_Click(object sender, EventArgs e)
        {
            checkEye(sender, e, "confirmSignUp");
        }
        private void eyePassSignIn_Click(object sender, EventArgs e)
        {
            checkEye(sender, e, "signIn");
        }

        //บัตรสมาชิก
        //ชื่อจริง
        private void nameFMember_TextChanged(object sender, EventArgs e)
        {
            nameFMemberCard.Text=funMemder(sender, e, nameFDataMemberCard, nameFMember.Text,"ชื่อ",10,9);
            dataMemberSave(sender, e);
        }

        //นามสกุล
        private void nameSMember_TextChanged(object sender, EventArgs e)
        {
            nameSMemberCard.Text = funMemder(sender, e, nameSDataMemberCard, nameSMember.Text, "นามสกุล", 6, 5);
            dataMemberSave(sender, e);
        }

        //เพศ
        private void female_Changed(object sender, EventArgs e)
        {
            changeGender(sender, e,"หญิง");
            dataMemberSave(sender, e);
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            changeGender(sender, e, "ชาย");
            dataMemberSave(sender, e);
        }

        private void lgbt_CheckedChanged(object sender, EventArgs e)
        {
            changeGender(sender, e, "LGBT");
            dataMemberSave(sender, e);
        }

        private void notSPGender_CheckedChanged(object sender, EventArgs e)
        {
            changeGender(sender, e, "ไม่ระบุ");
            dataMemberSave(sender, e);
        }

        //สถานภาพ
        private void single_CheckedChanged(object sender, EventArgs e)
        {
            changeStatus(sender, e, "โสด");
            dataMemberSave(sender, e);
        }

        private void marry_CheckedChanged(object sender, EventArgs e)
        {
            changeStatus(sender, e, "แต่งงาน");
            dataMemberSave(sender, e);
        }

        private void notSPStatus_CheckedChanged(object sender, EventArgs e)
        {
            changeStatus(sender, e, "ไม่ระบุ");
            dataMemberSave(sender, e);
        }

        private void otherStatus_CheckedChanged(object sender, EventArgs e)
        {
            changeStatus(sender, e, funotherStatus(sender, e));
            dataMemberSave(sender, e);
        }

        private void otherforStatus_TextChanged(object sender, EventArgs e)
        {
            if (otherStatus.Checked) { 
                changeStatus(sender, e, funotherStatus(sender, e));
                dataMemberSave(sender, e);
            }
        }

        //บริการพิเศษที่ลูกค้าต้องการเพิ่มเติม
        private void card_CheckedChanged(object sender, EventArgs e)
        {
            callchangeSV(sender, e);
        }

        private void consult_CheckedChanged(object sender, EventArgs e)
        {
            callchangeSV(sender, e);
        }

        private void otherSV_CheckedChanged(object sender, EventArgs e)
        {
            callchangeSV(sender, e);
        }

        private void otherforSV_TextChanged(object sender, EventArgs e)
        {
            callchangeSV(sender, e);
        }

        //โซนบัตรสมาชิกที่บันทึกข้อมูลแล้วกับบัตรในรูปแบบ Preview

        private void btnMemberL_Click(object sender, EventArgs e)
        {
            memderCard.Text = "Flowers of Paradise Membership Card";
            previewCard = false;
            dataMemberSave(sender, e);
            btnMemberTL.Hide();
            btnMemberTR.Show();
        }

        private void btnMemberR_Click(object sender, EventArgs e)
        {
            memderCard.Text = "Preview";
            previewCard = true;
            nameFMemberCard.Text = funMemder(sender, e, nameFDataMemberCard, nameFMember.Text, "ชื่อ", 10, 9);
            nameSMemberCard.Text = funMemder(sender, e, nameSDataMemberCard, nameSMember.Text, "นามสกุล", 6, 5);
            genderMemberCard.Text = funGender(sender, e);
            statusMemberCard.Text = funStatus(sender, e);
            btnMemberTR.Hide();
            btnMemberTL.Show();
        }
        private void indexforMember(object sender, EventArgs e)
        {
            //gender
            if (female.Checked)
                indexGender = 0;
            else if (male.Checked)
                indexGender = 1;
            else if (lgbt.Checked)
                indexGender = 2;
            else
                indexGender = 3;

            //status
            if (single.Checked)
                indexStatus = 0;
            else if (marry.Checked)
                indexStatus = 1;
            else if (notSPStatus.Checked)
                indexStatus = 2;
            else
                indexStatus = 3;

            //Service
            if (card.Checked)
                indexSV[0] = true;
            if (consult.Checked)
                indexSV[1] = true;
            if (otherSV.Checked)
                indexSV[2] = true;
        }

        //เซฟข้อมูลบัตรสมาชิก
        private void save_Click(object sender, EventArgs e)
        {
            funSave(sender, e);
            dataMemberSave(sender, e);
            indexforMember(sender, e);
        }

        //การลงทะเบียน
        private void user_TextChanged(object sender, EventArgs e)
        {
            checkNameRepeat(sender, e);
            if (userRepeat)
                textDesName.Text = "มีผู้ใช้ได้ใช้งานชื่อนี้แล้ว";
            else
                textDesName.Text = "";
        }

        private void passwordSignUp_TextChanged(object sender, EventArgs e)
        {
            if (passwordSignUp.Text.Length < 8)
                textDesPassword.Text = "กรุณาสร้างรหัสผ่านอย่างน้อย 8 อักขระ";
            else
                textDesPassword.Text = "";
            checkPassword(sender, e);
        }

        private void passwordConSignUp_TextChanged(object sender, EventArgs e)
        {
            checkPassword(sender, e);
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            //เช็กว่าชื่อผู้ใช้ซ้ำไหม
            if (!userRepeat)
            {
                if (passwordSignUp.Text.Length < 8)
                {
                    MessageBox.Show("ขออภัย! กรุณาสร้างรหัสผ่านอย่างน้อย 8 อักขระ\nโดยสามารถใช้ได้ทั้งตัวเลข ตัวอักษรรวมทั้งตัวอักขระพิเศษ");
                    passwordSignUp.Focus();
                }
                else { 
                    if (passwordConfirmOk)
                    {
                        MessageBox.Show("การลงทะเบียนสำเร็จ!");
                        List<string> fornewUser = new List<string> { newUser.Text, passwordSignUp.Text };
                        dataSignUp.Add(fornewUser);
                        Flowers.TabPages.Remove(windowSignUp);
                        callWindowUp(sender, e);    
                    }
                    else
                    {
                        MessageBox.Show("ขออภัย! รหัสผ่านกับรหัสยืนยันไม่ตรงกัน");
                        passwordConSignUp.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("มีผู้ใช้ได้ใช้งานชื่อนี้แล้ว");
                newUser.Focus();
            }
        }

        private void linkWindowIn_Click(object sender, EventArgs e)
        {
            Flowers.TabPages.Remove(windowSignUp);
            callWindowIn(sender, e);
        }

        //เข้าสู่ระบบ
        private void signIn_Click(object sender, EventArgs e)
        {
           Boolean member = false;
           foreach(List<string> checkSignIn in dataSignUp)
            {
                if (checkSignIn[0]==user.Text&& checkSignIn[1]==password.Text)
                {
                    MessageBox.Show("ลงชื่อเข้าใช้สำเร็จ!\nFlowers of Paradise\nยินดีให้บริการส่งมอบของขวัญที่แสนพิเศษให้คนที่คุณรัก");
                    Flowers.SelectedTab = Flowers.TabPages[3];
                    Flowers.TabPages.Remove(windowSignIn);
                    member = true;
                    break;
                }
                else if(checkSignIn[0] == user.Text) {
                    MessageBox.Show("ขออถัย! รหัสผ่านไม่ถูกต้อง");
                    describesUser.Text = "";
                    password.Text = "";
                    password.Focus();
                    describesPassword.Text = "รหัสผ่านไม่ถูกต้อง";
                    member = true;
                    break;
                }
            }
           if(!member)
            {
                MessageBox.Show("ชื่อผู้ใช้ไม่ถูกต้อง");
                Flowers.TabPages.Remove(windowSignIn);
                callWindowIn(sender, e);
                describesUser.Text = "ชื่อผู้ใช้ไม่ถูกต้อง";
                user.Focus();
            }
        }
        private void linkSingUp_Click(object sender, EventArgs e)
        {
            Flowers.TabPages.Remove(windowSignIn);
            callWindowUp(sender, e);
        }
    }
    }