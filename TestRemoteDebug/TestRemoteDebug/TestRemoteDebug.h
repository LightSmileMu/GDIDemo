
// TestRemoteDebug.h : PROJECT_NAME Ӧ�ó������ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"		// ������


// CTestRemoteDebugApp:
// �йش����ʵ�֣������ TestRemoteDebug.cpp
//

class CTestRemoteDebugApp : public CWinApp
{
public:
	CTestRemoteDebugApp();

// ��д
public:
	virtual BOOL InitInstance();

// ʵ��

	DECLARE_MESSAGE_MAP()
};

extern CTestRemoteDebugApp theApp;