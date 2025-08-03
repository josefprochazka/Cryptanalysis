using System.Text;

namespace Cryptanalysis
{
	public interface IEncryption
	{
		StringBuilder GetEncryptedText(StringBuilder plainText, Key key);
		StringBuilder GetDecryptedText(StringBuilder cipherText, Key key);
	}
}
