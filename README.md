# Cryptanalysis

This .NET application was developed as part of a bachelor thesis at VSB – Technical University of Ostrava (2019). It demonstrates cryptanalysis techniques for classical ciphers and serves as a learning tool for students and enthusiasts.

## Features

- **Caesar cipher** – brute-force decryption by shifting letters
- **Vigenère cipher** – key length estimation and breaking the cipher
- **Monoalphabetic substitution** – frequency-based letter matching
- Frequency analysis of ciphertexts
- Graphical representation of results

## Technologies

- .NET Framework (WinForms)
- C# language
- Visual Studio 2019
- Uses [Fody](https://github.com/Fody/Fody) for property change notifications

## How to run

1. Open `Cryptanalysis.sln` in Visual Studio  
2. Unblock DLL files if needed (via file properties or `Unblock-File` PowerShell command)  
3. Restore NuGet packages if required (the `packages` folder is included)

## License

This code is intended for educational and demonstration purposes only. It is not suitable for production use.

---

🧠 Author: Josef Procházka  
📘 Thesis: *Cryptanalysis of Classical Ciphers*, VSB-TUO, 2019
