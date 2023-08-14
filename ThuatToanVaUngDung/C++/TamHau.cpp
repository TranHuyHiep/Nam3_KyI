#include<bits/stdc++.h>
using namespace std;

int c[1000];
int cc[1000];
int cp[1000];
int dem = 0;
void Try(int k, int n) {
	if(k - 1 == n) {
		dem++;
	}
	else {
		for(int i = 0; i < n; i++) {
		if(c[i] == 0 && cc[i + k] == 0 && cp[k - i + n] == 0){
			c[i] = 1;
			cc[i + k] = 1;
			cp[k - i + n] = 1;
			Try(k + 1, n);
			c[i] = 0;
			cc[i + k] = 0;
			cp[k - i + n] = 0;
		}
	}
	}
}

int main()
{
    int n;
    cin >> n;
    Try(1, n);
	cout << dem;
}