   M S B A M L   `   `   `  ����I  EInterfacesCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:InterfacesCRUDInterfacesCRUD  5          InterfacesCRUD.Page3   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:InterfacesCRUD     5        N� Title$  Page3��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid3��5      $��4��6&   $��2��6:      AutoGenerateColumns$
 True��6K      
IsReadOnly$
 True��6f   �� 5   
   $��0��6   $��3��6%   
�������.+�5      �� -   5         ��Name$ btn_MostSold��5      $*��$Mostrar los 5 productos mas vendidos��6+   $��30��6Z   $	��350��6f   $��0 50 0 0q�6r   6�   5      �� 5!   
   $��1��6   $��3��6%   
�������.+�5#      �� -   5        $ btn_NoStock��5#      $%��Mostrar los productos sin Stock��6*   $��30��6T   $	��350��6`   $��0 50 0 0q�6l   6~   5%      �� 5'   
   $��3��6   $��3��6%   
�������.+�5)      �� -   5        $ btn_MostExpensive��5)      $'��!Mostrar los 5 productos mas caros��60   $��30��6\   $	��350��6h   $��0 50 0 0q�6t   6�   5+      5,      5-      