#include <iostream>
#include <fstream>
#include <algorithm>

using namespace std; 

#define maxchuso 100
#define cong 1
#define tru -1

typedef struct 
{
	char chuso[maxchuso];
	int dau;
	int sochuso;
}bignum;

//doc so lon a tu tep fi
void doc(bignum &a, ifstream &fi);
//kiem tra chuoi tam co phai la so lon
bool kiemtra(char tam[256]);
//kiem tra ky tu x co phai la chu so
bool lachuso(char x);
//in so lon a ra tep fo
void in(bignum a, ofstream &fo);
//so sanh 2 so lon
void sosanh(bignum a, bignum b, ofstream &fo);
//nap chong toan tu cho bignum
bool operator==(bignum a, bignum b);
bool operator>(bignum a, bignum b);
bignum operator+(bignum a, bignum b);
bignum operator-(bignum a, bignum b);

void main()
{
	ifstream fi;
	fi.open("bignuminp.txt");
	ofstream fo;
	fo.open("bignumout.txt");
	bignum a, b;
	doc(a, fi);
	doc(b, fi);
	fo << "so a: ";
	in(a, fo);
	fo << "so b: ";
	in(b, fo);
	fo << "so sanh: ";
	sosanh(a, b, fo);
	fo << "a + b = ";
	in(a + b, fo);
	fo << "a - b = ";
	in(a - b, fo);
	fi.close();
	fo.close();
}

void sosanh(bignum a, bignum b, ofstream &fo)
{
	if (a.sochuso == 0 || b.sochuso == 0)	//kiem tra du lieu dau vao
	{
		fo << "Bignum Error" << endl;
		return;
	}
	if (a == b)
		fo << "a = b" << endl;
	else
	if (a > b)
		fo << "a > b" << endl;
	else fo << "a < b" << endl;
}

bool operator==(bignum a, bignum b)
{
	if (a.sochuso != b.sochuso || a.dau != b.dau)
		return 0;
	for (int i = 0; i < a.sochuso; i++)
	if (a.chuso[i] != b.chuso[i])
		return 0;
	return 1;
}

bool operator>(bignum a, bignum b)
{
	if (a.dau < b.dau)			//so sanh dau
		return 0;
	if (a.dau > b.dau)		
		return 1;
	if (a.dau + b.dau == 2)		//so sanh so chu so voi TH ca 2 cung duong
	{
		if (a.sochuso < b.sochuso)
			return 0;
		if (a.sochuso > b.sochuso)
			return 1;
		for (int i = a.sochuso - 1; i >= 0; i--)
		if (a.chuso[i] < b.chuso[i])
			return 0;
		return 1;
	}
	if (a.dau + b.dau == -2)		//so sanh so chu so voi TH ca 2 cung am
	{
		if (a.sochuso < b.sochuso)
			return 1;
		if (a.sochuso > b.sochuso)
			return 0;
		for (int i = a.sochuso - 1; i >= 0; i--)
		if (a.chuso[i] > b.chuso[i])
			return 0;
		return 1;
	}
}

bignum operator+(bignum a, bignum b)
{
	bignum tong, x = a, y = b;
	if (a.sochuso == 0 || b.sochuso == 0)	//kiem tra du lieu dau vao
	{
		tong.sochuso = 0;
		return tong;
	}
	if (a.dau != b.dau)			//xet TH a, b trai dau
	{
		x.dau = cong;
		y.dau = cong;
		if (x == y)				//xet TH a, b la 2 so doi nhau
		{
			tong.chuso[0] = 48;
			tong.dau = cong;
			tong.sochuso = 1;
			return tong;
		}
		if (a.dau == cong)
			tong = x - y;		//a duong ==> a + (-b) = a - b
		else tong = y - x;		//a am	  ==> (-a) + b = b - a
		return tong;
	}
	if (a.sochuso < b.sochuso)	// b nhieu chu so hon a thi gan x=a, y=b
	{							// x chua so co nhieu chu so hon
		x = b;					// y chua so co it chu so hon
		y = a;
	}
	int du = 0, s = 0;
	for (int i = 0; i < x.sochuso; i++)			//cong tung ky tu cua a va b 
	{
		if (y.chuso[i] == -52)					//gap ky tu NULL ==> chuyen thanh ky tu 0
			y.chuso[i] = 48;
		s = x.chuso[i] + y.chuso[i] - 2 * 48;	//chuyen ky tu thanh so roi cong lai voi nhau
		tong.chuso[i] = (s + du) % 10 + 48;
		du = (s + du) / 10;
	}
	if (du != 0)								//neu so du !=0 thi tang so chu so cua tong len 1
	{
		tong.sochuso = x.sochuso + 1;
		tong.chuso[tong.sochuso] = du + 48;
	}
	else
		tong.sochuso = x.sochuso;
	tong.dau = a.dau;							//gan dau cua tong = dau cua a, b
	return tong;
}

bignum operator-(bignum a, bignum b)
{
	bignum hieu;
	if (a.sochuso == 0 || b.sochuso == 0)	//kiem tra du lieu dau vao co phai la bignum?
	{
		hieu.sochuso = 0;
		return hieu;
	}
	if (a == b)				//2 so bang nhau tru nhau bang 0
	{
		hieu.chuso[0] = '0';
		hieu.dau = cong;
		hieu.sochuso = 1;
		return hieu;
	}
	if (a.dau != b.dau)		//2 so trai dau tru nhau ==> chuyen sang phep cong
	{						// (-a) - b = (-a) + (-b)
		b.dau = a.dau;		// a- (-b) = a + b
		hieu = a + b;
		return hieu;
	}
	if (a.dau == tru)		//2 so cung am tru nhau
	{						// (-a) - (-b) = b - a
		a.dau = cong;
		b.dau = cong;
		hieu = b - a;
		return hieu;
	}
	if (b > a)				//2 so cung duong nhung b > a ==> a - b = - (b - a)
	{
		hieu = b - a;
		hieu.dau = tru;
		return hieu;
	}
	int muon = 0, h = 0;	//2 so cung duong va a > b
	for (int i = 0; i < a.sochuso; i++)
	{
		if (b.chuso[i] == -52)
			b.chuso[i] = 48;
		h = a.chuso[i] - b.chuso[i] - muon;
		muon = 0;
		if (h < 0)				//a.chuso[i] < b.chuso[i] nen phai muon 1 don vi
		{
			h += 10;
			muon = 1;
		}
		hieu.chuso[i] = h + 48;
	}
	hieu.dau = cong;
	int i = a.sochuso - 1;		//loai bo so 0 du o dau  
	while (hieu.chuso[i] == 48)	//VD: 00123 ==> 123
		i--;
	hieu.sochuso = i + 1;
	return hieu;
}

//bignum operator*(bignum a, bignum b)
//{
//	bignum tich;
//	if (a.dau - b.dau == 0)		//cung dau thi duong
//		tich.dau = cong;
//	else
//		tich.dau = tru;			//trai dau thi am
//	tich = nhan(a, b.chuso[0]);
//	for (int i = 1; i < b.sochuso; i++)
//		tich = tich + nhan(a, b.chuso[i]);
//	return tich;
//}
//
//bignum nhan(bignum a, int b)
//{
//	bignum x;
//	int nho;
//	for (int i = 0; i < a.sochuso; i++)
//
//}

void doc(bignum &a, ifstream &fi)
{
	char tam[256];
	fi >> tam;
	if (!kiemtra(tam))		//kiem tra chuoi co chua toan so khong
	{
		a.chuso[0] = 0;
		a.dau = cong;
		a.sochuso = 0;		//chuoi khong hop le
	}
	else
	{
		if (tam[0] != '-')		//kiem tra dau
		{
			a.dau = cong;		//so duong 
			a.sochuso = strlen(tam);
			for (int i = 0; i < a.sochuso; i++)
				a.chuso[i] = tam[a.sochuso - i - 1];
		}
		else
		{
			a.dau = tru;		//so am
			a.sochuso = strlen(tam) - 1;
			for (int i = 0; i < a.sochuso; i++)
				a.chuso[i] = tam[a.sochuso - i];
		}
	}
}

bool kiemtra(char tam[256])
{
	if (tam[0] != '-' && !lachuso(tam[0]))	//kiem tra ky tu dau tien
		return 0;
	else
	for (int i = 1; i < strlen(tam); i++)	//kiem tra cac ky tu tiep theo
	if (!lachuso(tam[i]))
		return 0;
	return 1;
}

bool lachuso(char x)
{
	if (x - 48 < 0 || x - 48 > 9)
		return 0;
	return 1;
}

void in(bignum a, ofstream &fo)
{
	if (a.sochuso == 0)
		fo << "Bignum Error";
	else
	{
		if (a.dau == tru)
			fo << "-";
		for (int i = a.sochuso - 1; i >= 0; i--)
			fo << a.chuso[i];
	}
	fo << endl;
}