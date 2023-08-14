#include <Windows.h>
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
int WINAPI WinMain(HINSTANCE hst, HINSTANCE preHst, PSTR cmdLine,  int nShow) 
{
	WNDCLASS wndClass;
	static TCHAR nameApp[25] = TEXT("Example 1");
	// Định nghĩa cấu trúc lớp cửa sổ
	wndClass.style = CS_HREDRAW | CS_VREDRAW;
	wndClass.lpfnWndProc = WndProc;
	wndClass.cbClsExtra = 0;
	wndClass.cbWndExtra = 0;
	wndClass.hInstance = hst;
	wndClass.hIcon = LoadIcon(hst, nameApp);
	wndClass.hCursor = LoadCursor(NULL, IDC_HAND);
	wndClass.lpszMenuName = NULL;
	wndClass.hbrBackground = (HBRUSH) GetStockObject(WHITE_BRUSH);
	wndClass.lpszClassName = nameApp;
	
	// Đăng ký lớp cửa sổ
	if(!RegisterClass(&wndClass))
	{
		MessageBox(NULL, TEXT("Error Windows"), TEXT("Error"), MB_OK);
		return 0;
	}
	
	// Tạo cửa sổ
	HWND hwnd = CreateWindow(nameApp, TEXT("Cửa sổ ứng dụng đầu tiên"),
		WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT,
		NULL, NULL, hst, NULL);
	ShowWindow(hwnd, nShow);
	UpdateWindow(hwnd);
	
	// Xử lý vòng lặp thông điệp
	MSG msg;
	while(GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return 0;
}

LRESULT CALLBACK WndProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam) 
{
	switch(message)
	{
		case WM_CLOSE:
			if(MessageBox(NULL, TEXT("Do you want to exit?"), TEXT("Yes/No"), MB_YESNO | MB_ICONQUESTION) == IDYES)
			{
				PostQuitMessage(0);
			}
			break;
		case WM_DESTROY:
			PostQuitMessage(0);
			break;
		default:
			return DefWindowProc(hwnd, message, wParam, lParam);
	}
	return 0;
}
