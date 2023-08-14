#include<bits/stdc++.h>
using namespace std;

int n, k1, k2;
void Try(string x, int k) {
	if(x.length() == n) {
		if(k >= k1 or k == 0){
			cout << x << endl;
		}
	}
	else {
		if(x == "" or k >= k1) {
			Try(x + "0", 0);
		}
		if(k < k2) {
			Try(x + "1", k + 1);
		}
	}
}

int main(){
	cin >> n >> k1 >> k2;
	Try("", 0);
}
