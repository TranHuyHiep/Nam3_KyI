#include<bits/stdc++.h>
using namespace std;

int main(){
	int n, ans = 0;
	cin >> n;
	map<string, int> m;
	for(int i = 0; i < n; i++){
		string a, b;
		cin >> a >> b;
		m[a + b]++;
		if(m[a+b] > ans) ans++;
	}
	cout << ans;
}
