#!/usr/bin/env python
# coding: utf-8

# In[30]:


import sys
import pandas as pd
import numpy as np
import importlib 


# In[12]:


m=importlib.import_module("ModelT")


# In[33]:


a=m.df['NameLevel']


# In[37]:


m.d[0][0]=51.115933
m.d[0][1]=17.141125
assert m.model.predict(m.d)== a[0], "Powinno być taka sama wartość"

assert m.model.predict(m.d)==a[2], "Powinno być taka sama wartość"


# In[38]:


m.d[0][0]=51
m.d[0][1]=17
assert m.model.predict(m.d)==a[0], "Wartość przewidziana powinna być taka sama w tym wypadku"

