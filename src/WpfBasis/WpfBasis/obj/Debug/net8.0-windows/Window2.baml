   M S B A M L   `   `   `  ����C  ?WpfBasis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfBasisWpfBasis  5   	       WpfBasis.Window2   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfBasis     5   	     � Title$  Window2��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   �� -   5         ��Name$ BackToMainButton��5
      $��
Назад��6+   $
��Left=�6;   $��36��6V   $��652,356,0,0q�6b   $	��Top=�6w   $��96��6�   6�   �� 5   
   -   5        $ CalculateButton��5      $��Считать��6*   $
��Left=�6<   $��28��6W   $��	438,0,0,0q�6c   $��Center=�6v   $	��100��6�   6�   �� 5   
   -   5         ��Name$ Operand1Box��5      $
��Left=�6'   $��28��6B   $��81,0,0,0q�6N    �� TextWrapping$
 Wrap=�6`   $��Операнд 1��6t   $��Center=�6�   $��91��6�   �� 5   
   -   5        $ SignBox��5      $
��Left=�6#   $��28��6>   $��	194,0,0,0q�6J   $
 Wrap=�6]   $��Оператор��6q   $��Center=�6�   $��91��6�   �� 5   
   -   5        $ Operand2Box��5      $
��Left=�6'   $��28��6B   $��	314,0,0,0q�6N   $
 Wrap=�6a   $��Операнд 2��6u   $��Center=�6�   $��91��6�   �� 5   
   $
��Left=�6   $��95��6/   $��	81,79,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��625��6z   �� 6�    � Language$ ru-ru�6�   $�Калькулятор.��6�   �� 6�   �� 6�   $ ru-ru�6�   �� 6�   �� 6�   $ ru-ru�6�   $@�:Доступные операнды: целые числа��6�   �� 6  �� 6+  $ ru-ru�6/  �� 6B  �� 6N  $ ru-ru�6R  $7�1Доступные операторы: +, -, *, /��6c  6�  �� 5   
   -   5         ��Name$ ResultLabel��5      $��Результат��6%   $
��Left=�69   $��28��6T   $��	587,0,0,0q�6`   $��Center=�6s   $	��119��6�   5      5      