   M S B A M L   `   `   `  ����I  EInterfacesCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:InterfacesCRUDInterfacesCRUD  5          InterfacesCRUD.Page2   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:InterfacesCRUD     5        N� Title$  Page2��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid2��5      $��4��6&   $��0��6:      AutoGenerateColumns$
 True��6G      
IsReadOnly$
 True��6b   �� 5   
   $��0��6   $��2��6%   
�������.+�5      �� -   5         ��Name$ 
btn_Select��5      $��Select��6)   $��30��6:   $��80��6F   $��0 30 0 0q�6j   �� 5      -   5         ��Name$ byProdId��5      $��ByProdId��6)   $��	10 60 0 0q�6<   �� 5      -   5        $ 
byProdName��5      $��
ByProdName��6+   $��	10 20 0 0q�6@   �� 5       -   5        $ byCategoryName��5       $��ByCategoryName��6/   $��	10 20 0 0q�6H   �� 5!      -   5         ��Name$ 
txt_Select��5!      $��
10 20 10 0q�6*   $
��Auto��6>   5"      �� 5$   
   $��1��6   $��1��6%   $��2��62   
�������.+�5&      �  5(      �� 5)      �� 5*       5,      �� 5-      �� 5.      .+�51      �� -   5        $ 
btn_Create��51      $��Create��6-   $��0��6>   $��30��6O   $��80��6[   $��0 30 0 0q�6   �� 52      -   5        $ 
btn_Update��52      $��Update��6-   $��1��6>   $��30��6O   $��80��6\   $��	0 30 30 0q�6�   �� 55      $��0��6   $��1��6-   	 �� Orientation$	 Vertical=�6:   $��	 0 15 0 0q�6Q   .+�56      �� $��ProdId:��6   $��Center=�6.   $��Center=�6I   �� 57      $��	ProdName:��6   $��Center=�60   $��Center=�6K   �� 58      $��SuppId:��6   $��Center=�6.   $��Center=�6I   �� 59      $��CateId:��6   $��Center=�6.   $��Center=�6I   �� 5:      $��	Quantity:��6   $��Center=�60   $��Center=�6K   �� 5;      $��Price:��6   $��Center=�6-   $��Center=�6H   �� 5<      $��Stock:��6   $��Center=�6-   $��Center=�6H   �� 5=      $��Order:��6   $��Center=�6-   $��Center=�6H   �� 5>      $��Reorder:��6   $��Center=�6/   $��Center=�6J   �� 5?      $��Discontinued:��6   $��Center=�64   $��Center=�6O   5@      �� 5B      $��1��6   $��1��6-   $	 Vertical=�6:   $��
 0 10 15 0q�6Q   .+�5C      �� -	   5        $ 
txt_ProdId��5C      $	��200��62   
 � ToolTip$

 Long��6A   �� 5D      -
   5        $ txt_ProdName��5D      $	��200��64   $
 String��6C   �� 5E      -   5        $ 
txt_SuppId��5E      $	��200��62   $

 Long��6A   �� 5F      -   5        $ 
txt_CateId��5F      $	��200��62   $

 Long��6A   �� 5G      -   5        $ txt_Quantity��5G      $	��200��64   $
 String��6C   �� 5H      -   5        $ 	txt_Price��5H      $	��200��61   $
 Double��6@   �� 5I      -   5        $ 	txt_Stock��5I      $	��200��61   $	
 Int��6@   �� 5J      -   5        $ 	txt_Order��5J      $	��200��61   $	
 Int��6@   �� 5K      -   5        $ txt_Reorder��5K      $	��200��63   $	
 Int��6B   �� 5L      -   5        $ txt_Discontinued��5L      $	��200��68   $
 Boolean��6G   5M      5N      5O      �� 5Q   
   $��3��6   $��2��6%   
�������.+�5S      �� -   5        $ 
btn_Delete��5S      $��Delete��6)   $��3��6:   $��1��6J   $��30��6W   $��80��6c   $��0 30 0 0q�6o   6�   �� 5U      $<��6Por favor elija el Id del producto que desea eliminar:��6   $��Center=�6U   $��0 60 0 0q�6r   �� 5V      -   5        $ txt_toDelete��5V      $	��200��6,   $

 Long��6;   $��
30 15 30 0q�6J   5W      5X      5Y      