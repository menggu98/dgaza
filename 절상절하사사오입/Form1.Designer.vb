<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.input = New System.Windows.Forms.TextBox()
        Me.output = New System.Windows.Forms.TextBox()
        Me.round = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.choose = New System.Windows.Forms.ComboBox()
        Me.value = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'input
        '
        Me.input.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.input.Font = New System.Drawing.Font("굴림", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.input.Location = New System.Drawing.Point(62, 147)
        Me.input.Multiline = True
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(159, 74)
        Me.input.TabIndex = 0
        '
        'output
        '
        Me.output.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.output.Font = New System.Drawing.Font("굴림", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.output.Location = New System.Drawing.Point(519, 147)
        Me.output.Multiline = True
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(159, 74)
        Me.output.TabIndex = 1
        '
        'round
        '
        Me.round.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.round.Location = New System.Drawing.Point(62, 248)
        Me.round.Name = "round"
        Me.round.Size = New System.Drawing.Size(324, 54)
        Me.round.TabIndex = 2
        Me.round.Text = "계산"
        Me.round.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.reset.Location = New System.Drawing.Point(392, 248)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(286, 54)
        Me.reset.TabIndex = 3
        Me.reset.Text = "지우기"
        Me.reset.UseVisualStyleBackColor = True
        '
        'choose
        '
        Me.choose.FormattingEnabled = True
        Me.choose.Location = New System.Drawing.Point(392, 147)
        Me.choose.Name = "choose"
        Me.choose.Size = New System.Drawing.Size(121, 20)
        Me.choose.TabIndex = 4
        '
        'value
        '
        Me.value.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.value.Font = New System.Drawing.Font("굴림", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.value.Location = New System.Drawing.Point(227, 147)
        Me.value.Multiline = True
        Me.value.Name = "value"
        Me.value.Size = New System.Drawing.Size(159, 74)
        Me.value.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "값을 입력"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "소수점을 처리할 자릿수"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(434, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "옵션"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(586, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "결과값"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.value)
        Me.Controls.Add(Me.choose)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.round)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.input)
        Me.Name = "Form1"
        Me.Text = "사사오입,절상,절사"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents input As TextBox
    Friend WithEvents output As TextBox
    Friend WithEvents round As Button
    Friend WithEvents reset As Button
    Friend WithEvents choose As ComboBox
    Friend WithEvents value As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
