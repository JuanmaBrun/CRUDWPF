   M S B A M L   `   `   `  ����I  EInterfacesCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:InterfacesCRUDInterfacesCRUD  5   	       InterfacesCRUD.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:InterfacesCRUD     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��800��6   $
��1400��6)      MaterialDesignBody#���   5
   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ��5   	   Z� .��5      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6     MaterialDesignPaper#���  63   $��25q�6f   .��5   
   )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ 
DialogHost��5   <      CloseOnClickAway$
 True��6$   .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�6P   .��5      �  � ColumnDefinitions 5      �� 5      $	��100 �6'   �� 5      .+�5      �� -   5        	 ��Name$	 sideMenu��5      
�������.+�5      �� $��img/logo.png��6   $��	0 80 0 50q�62   $��50��6E   $��50��6Q   �� 5      -   5        
 ��Name$
 btn_Home��5       � Cursor$
 Hand��6/   $��0 0 0 20q�6=   $��50��6P   $��50��6\    � ToolTip$! Mostrar todos los Productos��6~   ��5      �� 5        �� ImageSource$ img/Home.png��6)   5"      �� 5$      -   5        $
 btn_Crud��5$      $
 Hand��6/   $��0 0 0 20q�6=   $��50��6P   $��50��6\   $/ ) Cambiar a la ventana de Operaciones CRUD��6~   ��5%      �� 5&      $ img/Crud.png��6)   5(      �� 5*      -   5        $
 
btn_Prefab��5*      $
 Hand��61   $��0 0 0 20q�6?   $��50��6R   $��50��6^   $8 2 Cambiar a la ventana de Operaciones Prefabricadas��6�   ��5+      �� 5,      $ img/Prefab.png��6)   5.      �� 50      -   5        $
 	btn_Theme��50      $
 Hand��60   $��0 0 0 20q�6>   $��50��6P   $��50��6\   $" Cambiar al Modo Oscuro/Claro��6{   ��51      �� 52      $ img/Dark.png��6)   54      �� 56      -   5        $
 btn_Exit��56      $
 Hand��6/   $��0 0 0 20q�6=   $��50��6O   $��50��6[   $ Desconectar��6u   ��57      �� 58      $ img/Exit.png��6)   5:      5<       � 5>      -   5          �Name$ frame��5>      $��1��6'   5@      5A      5B      5C      