
using System.Collections;
using System.Text;

namespace steganography
{

	public class Message
	{

		 string content; // content of message

		// the constructor
		public Message(string leMessage)
		{
			content = leMessage;
		}

		
		public  byte[] toBytes()
		{
			byte[] byteTable;
			
                
               byteTable = Encoding.UTF8.GetBytes(content); 
			
			return byteTable;
		}

		
		public  BitArray parser()
		{
			byte[] MessageBytes = this.toBytes();
			BitArray MessageBits = new BitArray(MessageBytes.Length * 8);

			for (int i = 0; i < MessageBytes.Length * 8; i++)
			{
				if ((MessageBytes[MessageBytes.Length - i / 8 - 1] & (1 << (i % 8))) > 0)
				{
					MessageBits.Set(i, true);
				}
			}
			return MessageBits;
		}
        
	}

}