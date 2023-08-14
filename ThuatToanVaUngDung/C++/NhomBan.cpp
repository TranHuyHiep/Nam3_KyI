#include<bits/stdc++.h>
using namespace std;



class nhonban{
    int n,m,D[100005] = {}, F[100005] ={}, res=0,k;
    int root(int x){return F[x]==0?x:root(F[x]);}
    public:void sol() {
        cin >>n>>m;
        fill(D+1, D+n+1, 1);
        k=n;
        while(m--){
            int u,v;
            cin >> u >> v;
            int x=root(u), y = root (v);
            if (x!=y){
                while(u!=x) {int z=F[u]; F[u]=x; u=z;}
                while(v!=y) {int z=F[v]; F[v]=x; v=z;}
                F[y]=x;
                D[x]+=D[y];
                if(res<D[x]) res=D[x];
                k--;
            }
        }
        cout << k<<"\n"<<res;
    }
};

int main() {
    nhonban a;
    a.sol();
}