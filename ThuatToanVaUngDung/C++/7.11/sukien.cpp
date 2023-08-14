#include<bits/stdc++.h>
using namespace std;
#define ll long long

pair<ll, ll> pi[1000];

bool cmp(pair<ll, ll> a, pair<ll, ll> b) {
	if(a.first == b.first) {
		return a.first > b.first;
	}
	return a.second < b.second;
}

void Test() {
	ll n;
	cin >> n;
	for(ll i = 0; i < n;i ++) {
		long a, b;
		cin >> a >> b;
		pi[i] = {a, b};
	}
	sort(pi, pi + n, cmp);
	for(ll i = 0; i < n; i++) {
	}
	ll enda = - 1, endb = -1, ans = 0;
	for(ll i = 0; i < n; i++) {
		if(pi[i].first > enda and pi[i].first > endb) {
			if(enda > endb) {
				enda = pi[i].second;
				ans++;
				continue;
			} else {
				endb = pi[i].second;
				ans++;
				continue;
			}
		}
		if(pi[i].first > enda) {
			enda = pi[i].second;
			ans++;
			continue;
		}
		if(pi[i].first > endb) {
			endb = pi[i].second;
			ans++;
			continue;
		}
	}
	cout << ans << endl;
	
}

int main(){
	ll t;
	cin >> t;
	while(t--) {
		Test();
	}
}
