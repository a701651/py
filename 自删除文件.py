import os
b=input('是否删除文件？y/n')
if(b=='y'):
    a=__file__
    os.remove(a)
else:
    exit()