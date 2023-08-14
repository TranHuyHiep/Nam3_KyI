#include <bits/stdc++.h>
#define FR(i,a,b) for(ll i=a,_b=b;i<_b;i++)
#define endl '\n'
using namespace std;
typedef long long ll;
typedef unsigned long long ull;
pair<ll, ll> pr[1000];
bool compare(pair<ll, ll> a, pair<ll, ll> b){
	if (a.second == b.second)
		return a.first > b.first;
	return a.second < b.second;
}

void solve(const ll &n){
	FR(i, 0, n){
		cin >> pr[i].first >> pr[i].second;
	}
	sort(pr, pr+n, compare);
	ll enda = -1, endb = -1;
	int cnt = 0;
	FR(i, 0, n){
		if (pr[i].first > enda && pr[i].first > endb){
			if (enda>endb){
				enda = pr[i].second;
				cnt ++;
				continue;
			}
			else{
				endb = pr[i].second;
				cnt ++;
				continue;
			}
		}
		if (pr[i].first > enda){
			enda = pr[i].second;
			cnt ++;
			continue;
		}
		if (pr[i].first > endb){
			endb = pr[i].second;
			cnt ++;
			continue;
		}
	}
	cout << cnt << endl;
	return;
}

int main(){
	ios::sync_with_stdio(0); cin.tie(0); cout.tie(0);
	int t;
	cin >> t;
	while(t--){
		int n;
		cin >> n;
		solve(n);
	}
}


