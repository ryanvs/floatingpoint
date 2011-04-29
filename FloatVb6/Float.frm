VERSION 5.00
Begin VB.Form frmFloat 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Floating Point Debugger"
   ClientHeight    =   7275
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6240
   Icon            =   "Float.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7275
   ScaleWidth      =   6240
   StartUpPosition =   2  'CenterScreen
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   31
      Left            =   -45
      TabIndex        =   61
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   30
      Left            =   150
      TabIndex        =   60
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   29
      Left            =   330
      TabIndex        =   59
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   28
      Left            =   525
      TabIndex        =   58
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   27
      Left            =   720
      TabIndex        =   57
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   26
      Left            =   915
      TabIndex        =   56
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   25
      Left            =   1125
      TabIndex        =   55
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   24
      Left            =   1320
      TabIndex        =   54
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   23
      Left            =   1515
      TabIndex        =   53
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   22
      Left            =   1710
      TabIndex        =   52
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   21
      Left            =   1905
      TabIndex        =   51
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   20
      Left            =   2085
      TabIndex        =   50
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   19
      Left            =   2280
      TabIndex        =   49
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   18
      Left            =   2475
      TabIndex        =   48
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   17
      Left            =   2685
      TabIndex        =   47
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   16
      Left            =   2880
      TabIndex        =   46
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   15
      Left            =   3075
      TabIndex        =   45
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   14
      Left            =   3270
      TabIndex        =   44
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   13
      Left            =   3450
      TabIndex        =   43
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   12
      Left            =   3645
      TabIndex        =   42
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   11
      Left            =   3840
      TabIndex        =   41
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   10
      Left            =   4035
      TabIndex        =   40
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   9
      Left            =   4245
      TabIndex        =   39
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   8
      Left            =   4440
      TabIndex        =   38
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   7
      Left            =   4640
      TabIndex        =   37
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   6
      Left            =   4830
      TabIndex        =   36
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   5
      Left            =   5040
      TabIndex        =   35
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   4
      Left            =   5210
      TabIndex        =   34
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   3
      Left            =   5400
      TabIndex        =   33
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   2
      Left            =   5595
      TabIndex        =   32
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   1
      Left            =   5810
      TabIndex        =   31
      Top             =   1800
      Width           =   175
   End
   Begin VB.CheckBox chkBit 
      Caption         =   "Check1"
      Height          =   195
      Index           =   0
      Left            =   6000
      TabIndex        =   30
      Top             =   1800
      Width           =   175
   End
   Begin VB.TextBox txtUnsigned 
      Height          =   330
      Left            =   1260
      TabIndex        =   27
      Top             =   1170
      Width           =   1680
   End
   Begin VB.CommandButton cmdTwosCompl 
      Caption         =   "&2's"
      Height          =   255
      Left            =   3360
      TabIndex        =   26
      TabStop         =   0   'False
      ToolTipText     =   "2's Complement"
      Top             =   840
      Width           =   375
   End
   Begin VB.CommandButton cmdOnesCompl 
      Caption         =   "&1's"
      Height          =   255
      Left            =   3000
      TabIndex        =   25
      TabStop         =   0   'False
      ToolTipText     =   "1's Complement"
      Top             =   840
      Width           =   375
   End
   Begin VB.TextBox txtNumber 
      Height          =   330
      Left            =   1260
      TabIndex        =   24
      Top             =   810
      Width           =   1680
   End
   Begin VB.TextBox txtHex 
      Height          =   330
      Left            =   1260
      TabIndex        =   23
      Top             =   450
      Width           =   1320
   End
   Begin VB.ListBox lstMantissa 
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1860
      Left            =   45
      TabIndex        =   16
      Top             =   3990
      Width           =   4290
   End
   Begin VB.TextBox txtFloat 
      Height          =   330
      Left            =   1260
      TabIndex        =   1
      Top             =   90
      Width           =   1320
   End
   Begin VB.Line Line9 
      X1              =   0
      X2              =   4275
      Y1              =   1560
      Y2              =   1560
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Unsigned:"
      Height          =   195
      Index           =   11
      Left            =   120
      TabIndex        =   29
      Top             =   1200
      Width           =   720
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Base 10:"
      Height          =   195
      Index           =   10
      Left            =   120
      TabIndex        =   28
      Top             =   840
      Width           =   630
   End
   Begin VB.Line Line8 
      X1              =   90
      X2              =   4275
      Y1              =   6540
      Y2              =   6540
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Multplied:"
      Height          =   195
      Index           =   9
      Left            =   90
      TabIndex        =   22
      Top             =   6225
      Width           =   675
   End
   Begin VB.Label lblMultiply 
      Alignment       =   1  'Right Justify
      Caption         =   "1 "
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   240
      Left            =   990
      TabIndex        =   21
      Top             =   6225
      Width           =   3300
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Total:"
      Height          =   195
      Index           =   8
      Left            =   90
      TabIndex        =   20
      Top             =   5955
      Width           =   405
   End
   Begin VB.Label lblTotal 
      Alignment       =   1  'Right Justify
      Caption         =   "1 "
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   240
      Left            =   990
      TabIndex        =   19
      Top             =   5955
      Width           =   3300
   End
   Begin VB.Label lblResult 
      Alignment       =   1  'Right Justify
      BackColor       =   &H8000000D&
      Caption         =   "1 "
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   240
      Left            =   990
      TabIndex        =   18
      Top             =   6585
      Width           =   3300
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Result:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Index           =   7
      Left            =   90
      TabIndex        =   17
      Top             =   6630
      Width           =   615
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Binary Mantissa Base 2:"
      Height          =   195
      Index           =   6
      Left            =   90
      TabIndex        =   15
      Top             =   3765
      Width           =   1695
   End
   Begin VB.Line Line7 
      X1              =   90
      X2              =   4365
      Y1              =   3675
      Y2              =   3675
   End
   Begin VB.Line Line6 
      X1              =   90
      X2              =   4365
      Y1              =   2865
      Y2              =   2865
   End
   Begin VB.Line Line5 
      X1              =   3510
      X2              =   90
      Y1              =   2085
      Y2              =   2085
   End
   Begin VB.Label lblNumber 
      AutoSize        =   -1  'True
      Caption         =   "    "
      Height          =   195
      Index           =   0
      Left            =   2655
      TabIndex        =   14
      Top             =   120
      Width           =   180
   End
   Begin VB.Line Line4 
      X1              =   90
      X2              =   4365
      Y1              =   3405
      Y2              =   3405
   End
   Begin VB.Line Line3 
      X1              =   90
      X2              =   4365
      Y1              =   3135
      Y2              =   3135
   End
   Begin VB.Line Line2 
      X1              =   855
      X2              =   855
      Y1              =   2865
      Y2              =   3675
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Binary Notation:"
      Height          =   195
      Index           =   5
      Left            =   135
      TabIndex        =   3
      Top             =   1560
      Width           =   1125
   End
   Begin VB.Line Line1 
      X1              =   3510
      X2              =   90
      Y1              =   2355
      Y2              =   2355
   End
   Begin VB.Label lblBit 
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   480
      Index           =   0
      Left            =   135
      TabIndex        =   13
      Top             =   2400
      Width           =   105
   End
   Begin VB.Label lblDetail 
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   2
      Left            =   1035
      TabIndex        =   12
      Top             =   3420
      Width           =   3300
   End
   Begin VB.Label lblDetail 
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   1
      Left            =   1035
      TabIndex        =   10
      Top             =   3150
      Width           =   3300
   End
   Begin VB.Label lblDetail 
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   0
      Left            =   1035
      TabIndex        =   8
      Top             =   2895
      Width           =   3300
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Mantissa:"
      Height          =   195
      Index           =   4
      Left            =   90
      TabIndex        =   11
      Top             =   3450
      Width           =   675
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Exponent:"
      Height          =   195
      Index           =   3
      Left            =   90
      TabIndex        =   9
      Top             =   3180
      Width           =   720
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Sign:"
      Height          =   195
      Index           =   2
      Left            =   90
      TabIndex        =   7
      Top             =   2910
      Width           =   360
   End
   Begin VB.Label lblDec 
      Caption         =   "00000000000000000000000"
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   225
      Left            =   1080
      TabIndex        =   6
      Top             =   2130
      Width           =   2415
   End
   Begin VB.Label lblExp 
      Caption         =   "00000000"
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   225
      Left            =   240
      TabIndex        =   5
      Top             =   2130
      Width           =   840
   End
   Begin VB.Label lblSign 
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   225
      Left            =   135
      TabIndex        =   4
      Top             =   2130
      Width           =   105
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Floating Point:"
      Height          =   195
      Index           =   1
      Left            =   135
      TabIndex        =   0
      Top             =   180
      Width           =   1005
   End
   Begin VB.Label lblLabel 
      AutoSize        =   -1  'True
      Caption         =   "Hexadecimal:"
      Height          =   195
      Index           =   0
      Left            =   135
      TabIndex        =   2
      Top             =   510
      Width           =   960
   End
End
Attribute VB_Name = "frmFloat"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' The MIT License
'
' Copyright (c) 1999 Ryan Van Slooten
'
' Permission is hereby granted, free of charge, to any person obtaining a
' copy of this software and associated documentation files (the "Software"),
' to deal in the Software without restriction, including without limitation
' the rights to use, copy, modify, merge, publish, distribute, sublicense,
' and/or sell copies of the Software, and to permit persons to whom the
' Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in
' all copies or substantial portions of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
' FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
'
' Authors:
'   Ryan Van Slooten
'

Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" _
    (ByRef pvDst As Any, ByRef pvSrc As Any, ByVal cbCopy As Long)

Private aPower2(0 To 31)    As Long           ' Powers of 2
Private aIPower2(0 To 31)   As Single         ' Inverse Powers of 2
Private sMantissa(0 To 23)  As String         ' Mantissa Fractional Labels
Private mblnInit            As Boolean        ' Initialization Boolean

Public Enum NumberSource
    FromFloat
    FromHexadecimal
    FromInteger
End Enum

Private Const OFFSET_4 = 4294967296#
Private Const MAXINT_4 = 2147483647
Private Const OFFSET_2 = 65536
Private Const MAXINT_2 = 32767

Function UnsignedToLong(Value As Double) As Long
  If Value < 0 Or Value >= OFFSET_4 Then Error 6 ' Overflow
  If Value <= MAXINT_4 Then
    UnsignedToLong = Value
  Else
    UnsignedToLong = Value - OFFSET_4
  End If
End Function

Function LongToUnsigned(Value As Long) As Double
  If Value < 0 Then
    LongToUnsigned = Value + OFFSET_4
  Else
    LongToUnsigned = Value
  End If
End Function

Function UnsignedToInteger(Value As Long) As Integer
  If Value < 0 Or Value >= OFFSET_2 Then Error 6 ' Overflow
  If Value <= MAXINT_2 Then
    UnsignedToInteger = Value
  Else
    UnsignedToInteger = Value - OFFSET_2
  End If
End Function

Function IntegerToUnsigned(Value As Integer) As Long
  If Value < 0 Then
    IntegerToUnsigned = Value + OFFSET_2
  Else
    IntegerToUnsigned = Value
  End If
End Function

Public Function ClearForm(fHex As NumberSource)
  mblnInit = True
  Select Case fHex
  Case FromHexadecimal
    txtFloat.Text = ""
    txtNumber.Text = ""
    lblNumber(0).Caption = "Error"
  Case FromFloat
    txtHex.Text = ""
    txtNumber.Text = ""
    lblNumber(0).Caption = "Error"
  Case Else
    txtFloat.Text = ""
    txtHex.Text = ""
    lblNumber(0).Caption = "Error"
  End Select
  DumpIEEEFLoat 0
  mblnInit = False
End Function

Public Function DumpBits(Value As Long, aBits As Integer) As String
  Dim i As Integer
  For i = aBits - 1 To 0 Step -1
    DumpBits = DumpBits + IIf(CBool(Value And Power2(i)), "1", "0")
  Next i
End Function

Private Sub SetBitCheckboxes(Value As Long, aBits As Integer)
  Dim i As Integer
  For i = aBits - 1 To 0 Step -1
    chkBit(i).Value = IIf(CBool(Value And Power2(i)), vbChecked, vbUnchecked)
  Next i
End Sub

Public Sub DumpIEEEFLoat(Value As Long)
  Dim nExponent   As Integer
  Dim lngMantissa As Long
  Dim blnSign     As Boolean
  Dim lngTemp     As Long
  Dim strTemp     As String
  Dim strSign     As String         ' Signed Exponent (Unbiased)

  Call SetBitCheckboxes(Value, 32)
  strTemp = DumpBits(Value, 32)
  lblSign.Caption = Left(strTemp, 1)
  lblExp.Caption = Mid(strTemp, 2, 8)
  lblDec.Caption = Right(strTemp, 23)

  ' Sign Bit
  blnSign = CBool(Value And Power2(32))
  lblDetail(0).Caption = IIf(blnSign, "Negative", "Positive")
  
  ' Exponent
  lngTemp = Value And &H7F800000            ' Mask Bits
  lngTemp = lngTemp / Power2(23)            ' Right Shift >> 23
  nExponent = lngTemp - 127

  ' Show Exponent
  If nExponent = -127 Then
    strSign = "0 (-127) -> " + _
              "2^" + CStr(nExponent + 1) + " (Small)"
  Else
    strSign = CStr(lngTemp) + " -> " + _
              "2^" + CStr(nExponent) + " = " + _
              CStr(2 ^ (nExponent))
  End If
  lblDetail(1).Caption = StringWidth(strSign, 24) + _
                         "  0x" + FmtHex(lngTemp, 2)

  ' Mantissa
  lngMantissa = Value And &H7FFFFF              ' Mask Bits
  lblDetail(2).Caption = StringWidth(CStr(lngMantissa), 20) + _
                         "  0x" + FmtHex(lngMantissa, 6)

  ' Debug Mantissa
  ShowMantissaList Value, blnSign, nExponent
  
End Sub

Public Function FmtHex(ByVal i As Long, _
                       Optional ByVal iWidth As Integer = 8) As String
  FmtHex = Right$(String$(iWidth, "0") & Hex$(i), iWidth)
End Function

Public Function HexDumpBytes(s As String) As String
  Dim sLine As String
  Dim iCur As Integer
  Dim sCur As String
  Dim ab() As Byte
  Dim i As Integer

  ab = StrConv(s, vbFromUnicode)
'  ab = s
  For i = LBound(ab) To UBound(ab)
    ' Get current character
    iCur = ab(i)
    sCur = Chr$(iCur)

    ' Append its hex value
    sLine = sLine & Right$("0" & Hex$(iCur), 2) & " "
  Next i
  HexDumpBytes = sLine
  
End Function

Public Function HiByte(ByVal w As Long) As Byte
    HiByte = (w And &HFF00&) \ 256
End Function

Public Function LoByte(ByVal w As Long) As Byte
    LoByte = w And &HFF
End Function

Public Function MakeByteSigned(ByVal Value As Byte) As Integer
  MakeByteSigned = Value And &H7F
  If (Value And &H80) <> 0 Then
    MakeByteSigned = -MakeByteSigned
  End If
End Function

Public Function MakeFloat(ab As Long) As Single
  CopyMemory MakeFloat, ab, 4&
End Function

Public Function MakeInteger(bytHi As Byte, bytLo As Byte) As Integer
  MakeInteger = bytHi
  MakeInteger = MakeInteger * &H100 + bytLo
End Function

Public Function MakeIntLong(bytHi As Byte, bytLo As Byte) As Long
  MakeIntLong = bytHi
  MakeIntLong = MakeIntLong * &H100& + bytLo
End Function

Public Function MakeLong(intHi As Integer, intLo As Integer) As Long
  MakeLong = intHi
  MakeLong = MakeLong * &H10000 + intLo
End Function

Public Function MakeLongFloat(ab As Single) As Long
  CopyMemory MakeLongFloat, ab, 4&
End Function


Property Get Power2(ByVal i As Integer) As Long
    If Not (i >= 0 And i <= 31) Then Exit Property
    If aPower2(0) = 0 Then
        aPower2(0) = &H1&
        aPower2(1) = &H2&
        aPower2(2) = &H4&
        aPower2(3) = &H8&
        aPower2(4) = &H10&
        aPower2(5) = &H20&
        aPower2(6) = &H40&
        aPower2(7) = &H80&
        aPower2(8) = &H100&
        aPower2(9) = &H200&
        aPower2(10) = &H400&
        aPower2(11) = &H800&
        aPower2(12) = &H1000&
        aPower2(13) = &H2000&
        aPower2(14) = &H4000&
        aPower2(15) = &H8000&
        aPower2(16) = &H10000
        aPower2(17) = &H20000
        aPower2(18) = &H40000
        aPower2(19) = &H80000
        aPower2(20) = &H100000
        aPower2(21) = &H200000
        aPower2(22) = &H400000
        aPower2(23) = &H800000
        aPower2(24) = &H1000000
        aPower2(25) = &H2000000
        aPower2(26) = &H4000000
        aPower2(27) = &H8000000
        aPower2(28) = &H10000000
        aPower2(29) = &H20000000
        aPower2(30) = &H40000000
        aPower2(31) = &H80000000
    End If
    Power2 = aPower2(i)
End Property

Property Get Power2Inv(ByVal i As Integer) As Single
    If Not (i >= 0 And i <= 31) Then Exit Property
    If aIPower2(0) = 0 Then
      Dim j As Integer
      aIPower2(0) = &H1&
      For j = 1 To 31
        aIPower2(j) = aIPower2(j - 1) / 2
      Next j
    End If
    Power2Inv = aIPower2(i)
End Property

Private Function StringWidth(Value As String, ByVal Width As Integer, _
                             Optional ByVal fBefore As Boolean = False, _
                             Optional ByVal fTruncate As Boolean = False) As String
  If Len(Value) < Width Then
    If fBefore Then
      StringWidth = String$(Width - Len(Value), " ") + Value
    Else
      StringWidth = Value + String$(Width - Len(Value), " ")
    End If
  Else
    If fTruncate Then
      If fBefore Then
        StringWidth = Left$(Value, Width)
      Else
        StringWidth = Right$(Value, Width)
      End If
    Else
      StringWidth = Value
    End If
  End If
End Function

Private Function ShowMantissaList(ByVal Value As Long, ByVal fSign As Boolean, ByVal nExponent As Integer) As Single
  Dim strItem     As String
  Dim sngTotal    As Single
  Dim lngRemain   As Long     ' Fractional Remainder
  Dim lngFract    As Long     ' Highest Denominator (Fractional Component)
  Dim intBase     As Integer  ' Index of Highest Denominator
  Dim blnSmall    As Boolean  ' Small Floating Point where Exponent is Zero
  Dim i As Integer
  
  ' Check if Value is a Really Small Number
  If nExponent = -127 And (Value And &H7FFFFF) <> 0 Then
    blnSmall = True
    sngTotal = 0#
    nExponent = -126
    lstMantissa.List(0) = sMantissa(0) + vbTab + "0  (Small)"
  Else
    sngTotal = 1#
    lstMantissa.List(0) = sMantissa(0) + vbTab + "1  (Given)"
  End If

  ' Test each mantissa bit backwards to find the Lowest Common Denominator first
  For i = 23 To 1 Step -1
    If (Value And Power2(23 - i)) <> 0 Then
      If lngFract = 0 Then
        lngFract = Power2(i)
        intBase = i
      End If
      If intBase <> i Then
        lngRemain = lngRemain + Power2(intBase - i)
      Else
        lngRemain = 1
      End If

      sngTotal = sngTotal + Power2Inv(i)
      strItem = StringWidth(CStr(Power2Inv(i)), 6)
    Else
      strItem = "-"
    End If
    lstMantissa.List(i) = sMantissa(i) + vbTab + strItem
  Next i

  ' Adjust Mantissa
  If lngFract = 0 Then
    lngFract = 1
    lngRemain = 1
  Else
    ' Do not add One to Really Small Numbers (Exponent = 0)
    If nExponent <> 0 Then
      ' Add One to Mantissa (add Lowest Common Denominator)
      lngRemain = lngRemain + lngFract
    End If
  End If

  Dim strSign As String
  Dim strFraction As String
  strSign = IIf(CBool(Value And Power2(31)), "-", "")
  strFraction = strSign + "(" + CStr(lngRemain) + " / " + CStr(lngFract) + ")"

  lblTotal.Caption = strFraction + " = " + strSign + CStr(sngTotal) + " "
  lblMultiply.Caption = strFraction + " * 2^" + CStr(nExponent) + " "

  ' Check for NaNiness or for Zero
  If (nExponent = 128) Or (Value = 0) Then
    sngTotal = 0
  Else
    sngTotal = sngTotal * 2 ^ nExponent
    If CBool(Value And Power2(31)) Then
      sngTotal = -sngTotal
    End If
  End If
  lblResult.Caption = CStr(sngTotal) + " "

  ShowMantissaList = sngTotal

Exit_Handler:
  Exit Function

Err_Handler:
  If Err.Number <> 0 Then Err.Clear
  
End Function

Private Sub chkBit_Click(Index As Integer)
  If mblnInit Then Exit Sub
  On Error GoTo Err_Handler

  Dim i As Integer
  Dim lngValue As Long
  Dim sngValue As Single
  
  For i = LBound(chkBit) To UBound(chkBit)
    If chkBit(i).Value = vbChecked Then
      lngValue = lngValue And Power2(i)
    End If
  Next i

  sngValue = MakeFloat(lngValue)
  mblnInit = True
  txtNumber.Text = CStr(lngValue)
  txtFloat.Text = CStr(sngValue)
  txtHex.Text = FmtHex(lngValue, 8)
  lblNumber(0).Caption = CStr(sngValue)
  DumpIEEEFLoat lngValue
  mblnInit = False

Exit_Handler:
  Exit Sub

Err_Handler:
  ClearForm FromHexadecimal

End Sub

Private Sub cmdOnesCompl_Click()
  If mblnInit Then Exit Sub
  On Error GoTo Err_Handler

  Dim lngValue As Long
  Dim sngValue As Single
  lngValue = CLng(txtNumber.Text)
  lngValue = lngValue Xor &HFFFFFFFF
  sngValue = MakeFloat(lngValue)
  mblnInit = True
  txtNumber.Text = CStr(lngValue)
  txtFloat.Text = CStr(sngValue)
  txtHex.Text = FmtHex(lngValue, 8)
  lblNumber(0).Caption = CStr(sngValue)
  DumpIEEEFLoat lngValue
  mblnInit = False

Exit_Handler:
  Exit Sub

Err_Handler:
  ClearForm FromInteger

End Sub

Private Sub cmdTwosCompl_Click()
  If mblnInit Then Exit Sub
  On Error GoTo Err_Handler

  Dim lngValue As Long
  Dim sngValue As Single
  lngValue = CLng(txtNumber.Text)
  lngValue = (lngValue Xor &HFFFFFFFF) + 1
  sngValue = MakeFloat(lngValue)
  mblnInit = True
  txtNumber.Text = CStr(lngValue)
  txtFloat.Text = CStr(sngValue)
  txtHex.Text = FmtHex(lngValue, 8)
  lblNumber(0).Caption = CStr(sngValue)
  DumpIEEEFLoat lngValue
  mblnInit = False

Exit_Handler:
  Exit Sub

Err_Handler:
  ClearForm FromInteger

End Sub

Private Sub Form_Load()
  Dim strFont As String
  Dim intFont As Integer

  Dim sngHeight As Single
  Dim sngWidth As Single
  Dim strBit As String
  Dim i As Integer
  
  ' Align Labels
  strFont = "Courier New"
  intFont = 9
  
  Me.Font = strFont
  Me.FontSize = intFont
  lblSign.Font = strFont
  lblSign.FontSize = intFont
  lblExp.Font = strFont
  lblExp.FontSize = intFont
  lblDec.Font = strFont
  lblDec.FontSize = intFont
  lblBit(0).Font = strFont
  lblBit(0).FontSize = intFont

  sngWidth = Me.TextWidth("0")
  sngHeight = Me.TextHeight("0")

  lblSign.Width = sngWidth
  lblExp.Left = lblSign.Left + lblSign.Width
  lblExp.Width = sngWidth * 8
  lblDec.Left = lblExp.Left + lblExp.Width
  lblDec.Width = sngWidth * 23

  strBit = "32"
  lblBit(0).Left = lblSign.Left
  lblBit(0).Caption = Left(strBit, 1) + vbCrLf + Right(strBit, 1)

  For i = 1 To 31
    Load lblBit(i)
    If (i Mod 2) <> 0 Then
      lblBit(i).ForeColor = vbWhite
      lblBit(i).BackColor = &H404040
    Else
      lblBit(i).ForeColor = vbWindowText
    End If

    strBit = Format(32 - i, "00")
    lblBit(i).Caption = Left(strBit, 1) + vbCrLf + Right(strBit, 1)
    lblBit(i).Top = lblBit(i - 1).Top
    lblBit(i).Left = lblBit(i - 1).Left + sngWidth
    lblBit(i).Visible = True
    
    ' Test for check boxes
    'Load chkBit(i)
    chkBit(i).Top = chkBit(i - 1).Top
    chkBit(i).Left = chkBit(i - 1).Left - (chkBit(0).Width + 15)
    chkBit(i).Visible = True
  Next i
  
  Dim strItem As String
  Dim strMantissa As String
  For i = 0 To 23
    strItem = Format(i, "00")
    sMantissa(i) = strItem + "- " + " 1 /" + StringWidth(CStr(Power2(i)), 8, True) + " :"
    lstMantissa.AddItem sMantissa(i)
  Next i
  
  txtFloat.Text = "1"
  txtFloat.SelStart = Len(txtFloat.Text)
End Sub

Private Sub txtFloat_Change()
  If mblnInit Then Exit Sub
  On Error GoTo Err_Handler
    
  Dim lngValue As Long
  Dim sngValue As Single
  sngValue = CSng(txtFloat.Text)
  lngValue = MakeLongFloat(sngValue)
  mblnInit = True
  txtHex.Text = FmtHex(lngValue, 8)
  txtNumber.Text = CStr(lngValue)
  txtUnsigned.Text = CStr(LongToUnsigned(lngValue))
  lblNumber(0).Caption = CStr(sngValue)
  DumpIEEEFLoat lngValue
  mblnInit = False

Exit_Handler:
  Exit Sub

Err_Handler:
  ClearForm FromFloat

End Sub

Private Sub txtHex_Change()
  If mblnInit Then Exit Sub
  On Error GoTo Err_Handler

  Dim lngValue As Long
  Dim sngValue As Single
  lngValue = CLng("&H" + txtHex.Text)
  sngValue = MakeFloat(lngValue)
  mblnInit = True
  txtFloat.Text = CStr(sngValue)
  txtNumber.Text = CStr(lngValue)
  txtUnsigned.Text = CStr(LongToUnsigned(lngValue))
  lblNumber(0).Caption = CStr(sngValue)
  DumpIEEEFLoat lngValue
  mblnInit = False

Exit_Handler:
  Exit Sub

Err_Handler:
  ClearForm FromHexadecimal

End Sub

Private Sub txtNumber_Change()
  If mblnInit Then Exit Sub
  On Error GoTo Err_Handler

  Dim lngValue As Long
  Dim sngValue As Single
  lngValue = CLng(txtNumber.Text)
  sngValue = MakeFloat(lngValue)
  mblnInit = True
  txtFloat.Text = CStr(sngValue)
  txtHex.Text = FmtHex(lngValue, 8)
  txtUnsigned.Text = CStr(LongToUnsigned(lngValue))
  lblNumber(0).Caption = CStr(sngValue)
  DumpIEEEFLoat lngValue
  mblnInit = False

Exit_Handler:
  Exit Sub

Err_Handler:
  ClearForm FromInteger

End Sub
