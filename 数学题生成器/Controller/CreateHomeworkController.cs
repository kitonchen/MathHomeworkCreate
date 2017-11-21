using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;





namespace homework_create
{
    public class CreateHomeworkController
    {
        //控制器关联的视图和模型
        public HomeworkCreateView mainfrm;
<<<<<<< HEAD
        public CreateHomewordModel mainmodel;
=======
        public CreateHomeworkModel mainmodel;
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c

        public CreateHomeworkController(HomeworkCreateView Manfrm)
        {
            this.mainfrm = Manfrm;
            this.mainfrm.MController = this;
<<<<<<< HEAD
            mainmodel = new CreateHomewordModel();
        }

        public void Commnicate2Model(Object linkmodel)
        {
            this.mainmodel.Linkingmodel = linkmodel;
=======
            mainmodel = new CreateHomeworkModel();
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c
        }

        public void SetConfig(ArrayList Types,int Nums,int Rangmax,int Rangmin)
        {
            mainmodel.Mconfig = new Config()
            {
                Types = Types,
                Nums = Nums,
                RangMax = Rangmax,
                RangMin = Rangmin
            };
        }

        public ArrayList GetTypes(CheckedListBox ListBox)
        {
            //提取类型
            ArrayList Types = new ArrayList();
            for (int i = 0; i < ListBox.Items.Count; i++)
            {
                if (ListBox.GetItemChecked(i))//检查被勾选的值
                {//提取运算符号，加入arraylist中
                    Types.Add(ListBox.Items[i].ToString().Substring(2, 1));
                }
            }
            return Types;
        }

        public void SetFileDate(string FileDate)
        {//这里设计的不好，先用着吧
            mainmodel.MquestionCreate = new QuestionCreate
            {
                Mfiledate = FileDate
            };
        }

        public string GetFileDate()
        {
            return  mainmodel.MquestionCreate.Mfiledate;
        }

        public void SetGolbalSavePath(string path)
        {
            mainmodel.MquestionCreate.Msavepath =path;
        }

        public string GetGolbalSavePath()
        {
            return mainmodel.MquestionCreate.Msavepath;
        }

        public string GetSaveFileName()
        {
            return mainmodel.MquestionCreate.Mfiledate +"作业题.doc";
        }

        public Config GetConfig()
        {
            return mainmodel.Mconfig;
        }

        public string GetOneExperssion(ArrayList types,int rangmin,int rangmax,Random random)
        {
            //表达式相关构成
            string firstval, calchar, secondval;
            int second;

            //获取第一个整数
            firstval = random.Next(rangmin, rangmax).ToString();
            //获取运算符号
            calchar = types[random.Next(types.Count)].ToString();
            //获取第二个整数
            second = random.Next(rangmin, rangmax);
            //如果是除法的话，重新获取第二个数字,防止除0情况
            if (calchar == "/" && second == 0)
            {
                do
                {
                    second = random.Next(rangmin, rangmax);
                } while (second == 0);
            }

            if (second < 0)//第二个数小于0的话需要添加括号
            {
                secondval = "(" + second.ToString() + ")";
            }
            else
            {
                secondval = second.ToString();
            }

            return firstval + " " + calchar + " " + secondval + " =";
        }

        public void CreateTaskFileFromTemplate(string TemplatePath)
        {
            //根据模板创建一个word文档
            Report report = new Report();
            report.CreateNewDocument(TemplatePath);
            //相关变量
            int nums = GetConfig().Nums;//题目数量
            ArrayList types = GetConfig().Types;//运算类型           
            int rangmax = GetConfig().RangMax;//数值范围
            int rangmin = GetConfig().RangMin;
            
            //随机数
            Random random = new Random(5);
            //最终结果表达式 
<<<<<<< HEAD
            string experssion;

            //在书签处插入相关数据
            
            report.InsertValue("文件创建日期",GetFileDate());
=======
            string experssion;           
                         
            //在书签处插入相关数据
            report.InsertValue("文件创建日期", DateTime.Today.ToLongDateString());
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c
            report.InsertValue("题目数量", GetConfig().Nums.ToString());
            //创建表格
            int Rows = GetConfig().Nums / 5 + 1;
            int Cols = 5;
            Table table = report.InsertTable("表格", Rows, Cols, 450f);
            //不使用边框
            report.UseBorder(1, false);

            
            for (int Row = 1; Row <= Rows; Row++)
            {
                if (nums == 0) break;
                for (int Col = 1; Col <= Cols; Col++, nums--)
                {
                    if (nums == 0) break;
                    //获取一个表达式，并插入
                    experssion = GetOneExperssion(types,rangmin,rangmax,random);
                    report.InsertCell(table, Row, Col, experssion);
                }
            }
            //保存文件
            report.SaveDocument(GetGolbalSavePath());
            //写入配置文件
            Write2LocalInit("E:\\项目\\软件工程\\answercache\\Cacheinit.txt");
        }

        public void Write2LocalInit(string CacheLocalFile)
        {      
            FileStream fileStream = new FileStream(CacheLocalFile,FileMode.OpenOrCreate);
            byte[] data = System.Text.Encoding.Default.GetBytes(GetFileDate()+"\r\n");
            //设置偏移从文件最后写
            fileStream.Seek(0, SeekOrigin.End);
            fileStream.Write(data,0, data.Length);
            //刷新缓冲并关闭流
            fileStream.Flush();
            fileStream.Close();
        }

        public void RunCreateTask(SaveFileDialog SaveWordFile)
        {
            //只显示doc,docx文件
            SaveWordFile.Filter = " doc files(*.doc)|docx files(*.docx)";
<<<<<<< HEAD
            //设置文件日期
            SetFileDate(((MainModel)mainmodel.Linkingmodel).GetFileDate());
=======
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c
            //设置文件名字
            SaveWordFile.FileName = GetSaveFileName();
            if(SaveWordFile.ShowDialog() == DialogResult.OK)//选择的路径
            {//记录全局保存路径加文件名
<<<<<<< HEAD
               
=======
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c
                SetGolbalSavePath(SaveWordFile.FileName.ToString());
                CreateTaskFileFromTemplate("E:\\项目\\软件工程\\template\\template.doc");
            }
            else
            {
                return;
            }
            //关闭此窗口
            mainfrm.Close();
        }
    }

    public class Report
    {
        private _Application wordApp = null;
        private _Document wordDoc = null;
        public _Application Application
        {
            get
            {
                return wordApp;
            }
            set
            {
                wordApp = value;
            }
        }
        public _Document Document
        {
            get
            {
                return wordDoc;
            }
            set
            {
                wordDoc = value;
            }
        }

        // 通过模板创建新文档
        public void CreateNewDocument(string filePath)
        {
            try
            {
                KillWinWordProcess();
                wordApp = new ApplicationClass
                {
                    DisplayAlerts = WdAlertLevel.wdAlertsNone,
                    Visible = false
                };
                object missing = System.Reflection.Missing.Value;
                object templateName = filePath;
                wordDoc = wordApp.Documents.Open(ref templateName, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // 保存新文件
        public void SaveDocument(string filePath)
        {
            try
            {
                object fileName = filePath;
                object format = WdSaveFormat.wdFormatDocument;//保存格式
                object miss = System.Reflection.Missing.Value;
                wordDoc.SaveAs(ref fileName, ref format, ref miss,
                    ref miss, ref miss, ref miss, ref miss,
                    ref miss, ref miss, ref miss, ref miss,
                    ref miss, ref miss, ref miss, ref miss,
                    ref miss);
                //关闭wordDoc，wordApp对象
                object SaveChanges = WdSaveOptions.wdSaveChanges;
                object OriginalFormat = WdOriginalFormat.wdOriginalDocumentFormat;
                object RouteDocument = false;
                wordDoc.Close(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
                wordApp.Quit(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

<<<<<<< HEAD
        private void OpenDocument(string filePath)
        {

        }

=======
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c
        // 在书签处插入值
        public bool InsertValue(string bookmark, string value)
        {
            object bkObj = bookmark;
            if (wordApp.ActiveDocument.Bookmarks.Exists(bookmark))
            {
                wordApp.ActiveDocument.Bookmarks.get_Item(ref bkObj).Select();
                wordApp.Selection.TypeText(value);
                return true;
            }
            return false;
        }

<<<<<<< HEAD
        //读取书签处的值
        public string ReadValue(string bookmark)
        {
            object bkObj = bookmark;
            if (wordApp.ActiveDocument.Bookmarks.Exists(bookmark))
            {
                wordApp.ActiveDocument.Bookmarks.get_Item(ref bkObj).Select();
                return wordApp.Selection.Text;
            }
            return "";
        }

=======
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c
        // 插入表格,bookmark书签
        public Table InsertTable(string bookmark, int rows, int columns, float width)
        {
            object miss = System.Reflection.Missing.Value;
            object oStart = bookmark;
            Range range = wordDoc.Bookmarks.get_Item(ref oStart).Range;//表格插入位置
            Table newTable = wordDoc.Tables.Add(range, rows, columns, ref miss, ref miss);
            //设置表的格式
            newTable.Borders.Enable = 1;  //允许有边框，默认没有边框(为0时报错，1为实线边框，2、3为虚线边框，以后的数字没试过)
            newTable.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth050pt;//边框宽度
            if (width != 0)
            {
                newTable.PreferredWidth = width;//表格宽度
            }
            newTable.AllowPageBreaks = false;
            return newTable;
        }


        // 合并单元格 表id,开始行号,开始列号,结束行号,结束列号
        public void MergeCell(int n, int row1, int column1, int row2, int column2)
        {
            wordDoc.Content.Tables[n].Cell(row1, column1).Merge(wordDoc.Content.Tables[n].Cell(row2, column2));
        }

        // 合并单元格 表名,开始行号,开始列号,结束行号,结束列号
        public void MergeCell(Microsoft.Office.Interop.Word.Table table, int row1, int column1, int row2, int column2)
        {
            table.Cell(row1, column1).Merge(table.Cell(row2, column2));
        }

        // 设置表格内容对齐方式 Align水平方向，Vertical垂直方向(左对齐，居中对齐，右对齐分别对应Align和Vertical的值为-1,0,1)Microsoft.Office.Interop.Word.Table table
        public void SetParagraph_Table(int n, int Align, int Vertical)
        {
            switch (Align)
            {
                case -1: wordDoc.Content.Tables[n].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft; break;//左对齐
                case 0: wordDoc.Content.Tables[n].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;//水平居中
                case 1: wordDoc.Content.Tables[n].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight; break;//右对齐
            }
            switch (Vertical)
            {
                case -1: wordDoc.Content.Tables[n].Range.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalTop; break;//顶端对齐
                case 0: wordDoc.Content.Tables[n].Range.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter; break;//垂直居中
                case 1: wordDoc.Content.Tables[n].Range.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalBottom; break;//底端对齐
            }
        }

        // 设置单元格内容对齐方式
        public void SetParagraph_Table(int n, int row, int column, int Align, int Vertical)
        {
            switch (Align)
            {
                case -1: wordDoc.Content.Tables[n].Cell(row, column).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft; break;//左对齐
                case 0: wordDoc.Content.Tables[n].Cell(row, column).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;//水平居中
                case 1: wordDoc.Content.Tables[n].Cell(row, column).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight; break;//右对齐
            }
            switch (Vertical)
            {
                case -1: wordDoc.Content.Tables[n].Cell(row, column).Range.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalTop; break;//顶端对齐
                case 0: wordDoc.Content.Tables[n].Cell(row, column).Range.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter; break;//垂直居中
                case 1: wordDoc.Content.Tables[n].Cell(row, column).Range.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalBottom; break;//底端对齐
            }

        }


        // 设置表格字体
        public void SetFont_Table(Microsoft.Office.Interop.Word.Table table, string fontName, double size)
        {
            if (size != 0)
            {
                table.Range.Font.Size = Convert.ToSingle(size);
            }
            if (fontName != "")
            {
                table.Range.Font.Name = fontName;
            }
        }

        // 设置单元格字体
        public void SetFont_Table(int n, int row, int column, string fontName, double size, int bold)
        {
            if (size != 0)
            {
                wordDoc.Content.Tables[n].Cell(row, column).Range.Font.Size = Convert.ToSingle(size);
            }
            if (fontName != "")
            {
                wordDoc.Content.Tables[n].Cell(row, column).Range.Font.Name = fontName;
            }
            wordDoc.Content.Tables[n].Cell(row, column).Range.Font.Bold = bold;// 0 表示不是粗体，其他值都是
        }

        // 是否使用边框,n表格的序号,use是或否
        // 该处边框参数可以用int代替bool可以让方法更全面
        // 具体值方法中介绍
        public void UseBorder(int n, bool use)
        {
            if (use)
            {
                wordDoc.Content.Tables[n].Borders.Enable = 1;
                //允许有边框，默认没有边框(为0时无边框，1为实线边框，2、3为虚线边框，以后的数字没试过)
            }
            else
            {
                wordDoc.Content.Tables[n].Borders.Enable = 0;
            }
        }

        // 给表格插入一行,n表格的序号从1开始记
        public void AddRow(int n)
        {
            object miss = System.Reflection.Missing.Value;
            wordDoc.Content.Tables[n].Rows.Add(ref miss);
        }

        // 给表格添加一行
        public void AddRow(Microsoft.Office.Interop.Word.Table table)
        {
            object miss = System.Reflection.Missing.Value;
            table.Rows.Add(ref miss);
        }

        // 给表格插入rows行,n为表格的序号
        public void AddRow(int n, int rows)
        {
            object miss = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Table table = wordDoc.Content.Tables[n];
            for (int i = 0; i < rows; i++)
            {
                table.Rows.Add(ref miss);
            }
        }

        // 删除表格第rows行,n为表格的序号
        public void DeleteRow(int n, int row)
        {
            Microsoft.Office.Interop.Word.Table table = wordDoc.Content.Tables[n];
            table.Rows[row].Delete();
        }

        // 给表格中单元格插入元素，table所在表格，row行号，column列号，value插入的元素
        public void InsertCell(Microsoft.Office.Interop.Word.Table table, int row, int column, string value)
        {
            table.Cell(row, column).Range.Text = value;
        }

        //读取表格中单元格元素，table所在表格，row行号，column列号，value插入的元素
        public string ReadCell(Microsoft.Office.Interop.Word.Table table, int row, int column, string value)
        {
            return table.Cell(row, column).Range.Text;
        }
        // 给表格中单元格插入元素，n表格的序号从1开始记，row行号，column列号，value插入的元素
        public void InsertCell(int n, int row, int column, string value)
        {
            wordDoc.Content.Tables[n].Cell(row, column).Range.Text = value;
        }

        // 给表格插入一行数据，n为表格的序号，row行号，columns列数，values插入的值
        public void InsertCell(int n, int row, int columns, string[] values)
        {
            Microsoft.Office.Interop.Word.Table table = wordDoc.Content.Tables[n];
            for (int i = 0; i < columns; i++)
            {
                table.Cell(row, i + 1).Range.Text = values[i];
            }
        }

        // 插入图片
        public void InsertPicture(string bookmark, string picturePath, float width, float hight)
        {
            object miss = System.Reflection.Missing.Value;
            object oStart = bookmark;
            Object linkToFile = false;       //图片是否为外部链接
            Object saveWithDocument = true;  //图片是否随文档一起保存 
            object range = wordDoc.Bookmarks.get_Item(ref oStart).Range;//图片插入位置
            wordDoc.InlineShapes.AddPicture(picturePath, ref linkToFile, ref saveWithDocument, ref range);
            wordDoc.Application.ActiveDocument.InlineShapes[1].Width = width;   //设置图片宽度
            wordDoc.Application.ActiveDocument.InlineShapes[1].Height = hight;  //设置图片高度
        }

        // 插入一段文字,text为文字内容
        public void InsertText(string bookmark, string text)
        {
            object oStart = bookmark;
            object range = wordDoc.Bookmarks.get_Item(ref oStart).Range;
            Paragraph wp = wordDoc.Content.Paragraphs.Add(ref range);
            wp.Format.SpaceBefore = 6;
            wp.Range.Text = text;
            wp.Format.SpaceAfter = 24;
            wp.Range.InsertParagraphAfter();
            wordDoc.Paragraphs.Last.Range.Text = "\n";
        }

        // 杀掉winword.exe进程
        public void KillWinWordProcess()
        {
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("WINWORD");
            foreach (System.Diagnostics.Process process in processes)
            {
                bool b = process.MainWindowTitle == "";
                if (process.MainWindowTitle == "")
                {
                    process.Kill();
                }
            }
        }
    }
}
