#include<bits/stdc++.h>
using namespace std;

int ans = INT_MAX;
int a[9];
int n[3];
void Try(int temp[], int k) {
	if(k == 3) {
		sort(n, n + 2);
		ans = min(ans, a[2] - a[0]);
		return;
	}
	for(int i = 0; i < 2; i++) {
		temp[i] += a[k * i + (k % i)];
	}
	Try(temp, k++);
}

int main(){
	for(int i = 0; i < 9; i++) {
		cin >> a[i];
	}
	sort(a, a + 9);
	int temp[9] = {};
	Try(temp, 0);
	cout << ans;
}
