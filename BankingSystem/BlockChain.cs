using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingSystem
{
    struct Block
    {
        public int index;
        public string hash;
        public string previoushash;
        public string timestamp;
        public string data;
    }
    class BlockChain
    {

        List<Block> blocks;

        public BlockChain()
        {
            blocks = new List<Block>();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlCommand writecmd = new SqlCommand();
            cmd.Connection = con;
            writecmd.Connection = con;
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM BlockTable";
            reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                string time = DateTime.Now.ToFileTime().ToString();
                CreateBlock(0, "816534932c2b7154836da6afc367695e6337db8a921823784c14378abed4f7d7", null, time, "Genesis Block!", true);
                reader.Close();
                writecmd.CommandText = "INSERT into BlockTable([Index],Hash,TimeStamp,Data) VALUES('0','816534932c2b7154836da6afc367695e6337db8a921823784c14378abed4f7d7','" + time + "','Genesis Block!')";
                writecmd.ExecuteNonQuery();
            }
            else
                reader.Close();
            con.Close();
        }

        private void CreateBlock(int index, string hash, string previoushash, string timestamp, string data, bool isreading)
        {
            Block block = new Block();
            block.index = index;
            if (isreading)
            {
                block.hash = hash;
            }
            else
            {
                block.hash = CalculateHash(index, previoushash, timestamp, data);
            }
            block.previoushash = previoushash;
            block.timestamp = timestamp;
            block.data = data;
            blocks.Add(block);
        }

        public void AddBlock()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlCommand writecmd = new SqlCommand();
            cmd.Connection = con;
            writecmd.Connection = con;
            SqlDataReader reader;

            int index;
            string hash;
            string previoushash;
            string timestamp;

            cmd.CommandText = "SELECT TOP 1 * FROM BlockTable ORDER BY [Index] DESC";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (!reader.IsClosed && reader.Read())
                {
                    index = Convert.ToInt32(reader["Index"].ToString()) + 1;
                    previoushash = reader["Hash"].ToString();
                    timestamp = DateTime.Now.ToFileTime().ToString();
                    hash = CalculateHash(index, previoushash, timestamp, "Block" + index);
                    CreateBlock(index, hash, previoushash, timestamp, "Block" + index, false);
                    reader.Close();
                    cmd.CommandText = "INSERT into BlockTable([Index],Hash,PreviousHash,TimeStamp,Data) VALUES('" + index + "','" + hash + "','" + previoushash + "','" + timestamp + "','" + "Block" + index + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            else
                reader.Close();
            con.Close();
        }
        private string CalculateHash(int index, string previoushash, string timestamp, string data)
        {
            return index + previoushash + timestamp + data;
        }

        private bool ValidateBlock(Block currentblock, Block previousblock)
        {
            if (currentblock.previoushash == previousblock.hash)
                return true;
            else
                return false;
        }

        public bool ReadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataReader reader;

            cmd.CommandText = "SELECT * from BlockTable";     
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                CreateBlock(Convert.ToInt32(reader["Index"].ToString()), reader["Hash"].ToString(), reader["PreviousHash"].ToString(), reader["TimeStamp"].ToString(), reader["Data"].ToString(), true);
            }
            for (int i = 1; i < blocks.Count; i++)
            {
                if (!ValidateBlock(blocks[i], blocks[i - 1]))
                {
                    Console.WriteLine(blocks[i].previoushash);
                    Console.WriteLine(blocks[i - 1].hash);
                    Console.WriteLine("Vulnerability at " + (i - 1));           
                    return false;
                }
            }
            reader.Close();
            con.Close();
            return true;
        }
    }
}
