   M S B A M L   `   `   `  ����  HisaabManagement!    HisaabManagement.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Hissab Management��5   	   $	��650��6#   $
��1000��60    � Icon$ images/favicon.ico��6=   .��5      � $��0,0,0,33q�6   .+�5   
   �� $
��Left=�6   $��85��6+   $	��Top=�67   $��95��6O   $��
427,49,0,0q�6Z   $��images/logo.jpg��6n   �� 5   
   $��Last Transaction from��6   $
��Left=�60   $	��Top=�6K   $��
557,71,0,0q�6c   $��14(�6w   $��Arial Black)�6�   �� 5   
   $��Remarks��6   $
��Left=�6"   $	��Top=�6=   $��658,102,0,0q�6U   $��14(�6j   $��Arial Black)�6x   �� 5	   
   -   5        $��lsttransactionfrom��5	   &   $��labellsttxn��6   $
��Left=�6@   $	��Top=�6[   $��
753,71,0,0q�6s   �� 5
   
   -   5         ��Name$  lsttransactionfrom_remarks��5
   '   $��labelremarks��6   $
��Left=�6K   $	��Top=�6f   $��
753,97,0,0q�6~    J� RenderTransformOrigin$ 0.438,1.764&�6�   $��27��6�   �� 5   
   $��Make Transaction��6   $
��Left=�6+   $	��Top=�6F   $��378,134,0,0q�6^   $��20(�6s   $��Arial Black)�6�   �� 5   
   $��From Transaction��6   $
��Left=�6+   $	��Top=�6F   $��268,191,0,0q�6^   $��14(�6s   $��Arial Black)�6�   �� 5   
   -   5        $��combofromtransaction��5   /   $
��Left=�6   $	��Top=�6K   $	��120��6c   $��504,195,0,0q�6o   .@�5      �� $��41��6   $	��138��6#   �� 5      $	��100��6   $	��100��6#   5      �� 5   
   -   5        $��listboxtotxn��5   G   $
��Left=�6    �� SelectionMode$ Multiple=�6-   $	��100��6[   $	��Top=�6h   $	��100��6�   $��504,241,0,0q�6�   �� 5   
   $��Distribute Transaction��6   $
��Left=�61   $	��Top=�6L   $��231,274,0,0q�6d   $��14(�6y   $��Arial Black)�6�   �� 5   
   $��Amount��6   $
��Left=�6!   $	��Top=�6<   $��344,375,0,0q�6T   $��14(�6i   $��Arial Black)�6w   �� 5   
   -   5        $��	txtamount��5   U   $
��Left=�6   $��23��6-    �� TextWrapping$
 Wrap=�69   $�� ��6M   $	��Top=�6f   $	��120��6~   $��504,375,0,0q�6�   �� 5   
   $��Remarks��6   $
��Left=�6"   $	��Top=�6=   $��335,434,0,0q�6U   $��14(�6j   $��Arial Black)�6x   �� 5   
   -   5         ��Name$ 
txtremarks��5   U   $
��Left=�6   $��23��6-   $
 Wrap=�69   $�� ��6M   $	��Top=�6i   $	��331��6�   $��504,442,0,0q�6�   �� 5   
   -   5        $��	btnsubmit��5   =   $��Submit��6   $
��Left=�6"   $	��Top=�6N   $��75��6f   $��427,497,0,0q�6q   6�   o� 5   
   $
��Left=�6   $��22��6*   $	��Top=�66   $	��992��6N   $��0,-3,0,0q�6Z   $
��Bold"�6l   $��16(�6~   .@�5      m� $��Distributed Transaction��6   m� 5      -   5        $��menu_insivisualtxn��5   7   $��Indivisual Transaction��6   6Q   m� 5      -	   5        $��Check balance��5      6.   m� 5      -
   5        $��menutotaltxn��5   3   $��Total Transactions��6   6G   5      � 5   
   -   5        $��progressbar��5   K   $
��Left=�6    � Maximum$	 100Q�61    � Minimum$ 0Q�6?   $��20��6^   $	��Top=�6j   $	��577��6�   $��192,544,0,0q�6�   5       5!      