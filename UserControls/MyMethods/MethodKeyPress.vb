Public Module MethodKeyPress

    ''' <summary>
    '''  Происходит при нажатии клавиши, если элемент управление имеет фокус. 
    '''  Элемент управление получает только положительное значение с плавающей точкой.
    '''  Даннаю процедуру нужно визывать в событии 'KeyPress'
    ''' </summary>
    ''' <param name="sender"> Элемент управления </param>
    ''' <param name="e"> Данные о событые </param>
    ''' <remarks></remarks>
    Public Sub PositiveDoubleValueInControlKeyPress(sender As Object, e As KeyPressEventArgs)
        ' (.) меняется на (,)
        If e.KeyChar = "." Then e.KeyChar = ","
        ' При первой нажатии (,) или (.), текст меняется на (0,)
        If sender.Text.Length = 0 And e.KeyChar = "," Then e.KeyChar = "" _
                                        : sender.Text = "0," : sender.Select(sender.Text.Length, 0)
        ' Проверка вводимых символов
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "," Or
            e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Delete)) Then
            ' Проверка (,) в эелементе управление и запрет ввода (,) и (.)
            If sender.Text.IndexOf(",") >= 0 And e.KeyChar = "," Then e.Handled = True
        Else
            ' Запред ввода недопустимых символов
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    '''  Происходит при нажатии клавиши, если элемент управление имеет фокус. 
    '''  Элемент управление получает положительное и отрицательное значение с плавающей точкой. 
    '''  Даннаю процедуру нужно визывать в событии 'KeyPress'
    ''' </summary>
    ''' <param name="sender"> Элемент управления </param>
    ''' <param name="e"> Данные о событые </param>
    ''' <remarks></remarks>
    Public Sub DoubleValueInControlKeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = "-" Then If sender.text = "" Then e.KeyChar = "" : sender.text = -1 : sender.select(sender.text.length - 1, 1) _
                                Else e.KeyChar = "" : sender.text = sender.text * (-1) : sender.Select(sender.Text.Length, 0)
        If e.KeyChar = "+" Then If Val(sender.text) < 0 Then e.KeyChar = "" : sender.text = sender.text * (-1) : sender.Select(sender.Text.Length, 0)
        ' (.) меняется на (,)
        If e.KeyChar = "." Then e.KeyChar = ","
        ' При первой нажатии (,) или (.), текст меняется на (0,)
        If sender.Text.Length = 0 And e.KeyChar = "," Then e.KeyChar = "" _
                                        : sender.Text = "0," : sender.Select(sender.Text.Length, 0)
        ' Проверка вводимых символов
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "," Or
            e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Delete)) Then
            ' Проверка (,) в эелементе управление и запрет ввода (,) и (.)
            If sender.Text.IndexOf(",") >= 0 And e.KeyChar = "," Then e.Handled = True
        Else
            ' Запред ввода недопустимых символов
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    '''  Происходит при нажатии клавиши, если элемент управление имеет фокус. 
    '''  Элемент управление получает только положительное целое значение.
    '''  Даннаю процедуру нужно визывать в событии 'KeyPress'
    ''' </summary>
    ''' <param name="sender"> Элемент управления </param>
    ''' <param name="e"> Данные о событые </param>
    ''' <remarks></remarks>
    Public Sub PositivIntegerValueInControlKeyPress(sender As Object, e As KeyPressEventArgs)
        ' Проверка вводимых символов
        If e.KeyChar = "." Then e.Handled = True
        If e.KeyChar = "0" Then If sender.text = "" Then e.KeyChar = ""
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Delete)) Then
        Else
            ' Запред ввода недопустимых символов
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    '''  Происходит при нажатии клавиши, если элемент управление имеет фокус. 
    '''  Элемент управление получает только положительное и отрицательное целое значение.
    '''  Даннаю процедуру нужно визывать в событии 'KeyPress'
    ''' </summary>
    ''' <param name="sender"> Элемент управления </param>
    ''' <param name="e"> Данные о событые </param>
    ''' <remarks></remarks>
    Public Sub IntegerValueInControlKeyPress(sender As Object, e As KeyPressEventArgs)

        If e.KeyChar = "-" Then If sender.text = "" Then e.KeyChar = "" : sender.text = -1 : sender.select(sender.text.length - 1, 1) _
                               Else e.KeyChar = "" : sender.text = sender.text * (-1) : sender.Select(sender.Text.Length, 0)
        If e.KeyChar = "+" Then If Val(sender.text) < 0 Then e.KeyChar = "" : sender.text = sender.text * (-1) : sender.Select(sender.Text.Length, 0)
        ' Проверка вводимых символов
        If e.KeyChar = "." Then e.Handled = True
        If e.KeyChar = "0" Then If sender.text = "" Then e.KeyChar = ""
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = CChar(ChrW(Keys.Back)) Then
        Else
            ' Запред ввода недопустимых символов
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Происхотит при изменение текста в элементе управление. Переобразует первую букву каждого слово в строке в букву верхного регистра
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub ProperCase(sender As Object, e As EventArgs)
        sender.text = StrConv(sender.text, VbStrConv.ProperCase)
        If sender.text = " " Then sender.text = ""
        sender.SelectionStart = sender.text.Length
    End Sub
End Module
