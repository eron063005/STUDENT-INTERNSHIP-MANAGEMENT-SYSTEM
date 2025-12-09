# Platform Technology
# Final Case Study
# 
# BSIT - 2D 
# 
# MEMBERS:    
# Sam Aidan C. Gonzaga
# Aaron G. Cayabyab
# Vehniah P. Samson

import pandas as pd
import numpy as np
import matplotlib.pyplot as plt 
import seaborn as sns
from sklearn.metrics import confusion_matrix
import sys

# sys.argv[0] is the script name, sys.argv[1] is the first argument


file_path = sys.argv[1]

# Now you can read CSV/Excel
if file_path.lower().endswith(".csv"):
    df = pd.read_csv(file_path)
elif file_path.lower().endswith((".xls", ".xlsx")):
    import openpyxl  # or xlrd for older Excel
    df = pd.read_excel(file_path)
else:
    print("Unsupported file type.")
    sys.exit(1)

print("Data loaded successfully!")
print(df.head())



# Get summary Statistics for numeric columns 
df.describe()


df.shape

df.isnull().sum()




df['StudentID'] = df['StudentID'].astype(str).str.extract(r'(\d+)').astype(int)
# Example: your data

# Mapping dictionary
rating_map = {
    'Outstanding': 5,   # Outstanding
    'Very Satisfactory': 4,  # Very Satisfactory
    'Satisfactory': 3,   # Satisfactory
    'Fair': 2,   # Fair
    'Unsatisfactory': 1    # Unsatisfactory
}

# Map text labels to numeric
df['Equivalent Rating'] = df['Equivalent Rating'].map(rating_map)

# Data Engineering / Pre-processing
#Convert, normalize, or encode your features before modeling

from sklearn.preprocessing import StandardScaler

start_idx = df.columns.get_loc("Attends regularly.")
cols = list(df.columns[start_idx: - 1])

print(cols)

# Standardize average score
scaler = StandardScaler()
df['Total Points Earned'] = scaler.fit_transform(df[['Total Points Earned']])

# Make class to float
df['Remark'] = df['Remark'].replace({'Passed': 1.0, 'Failed': 0.0}).astype(float)

print(df['Remark'].value_counts())

# Data Splitting (Training and Testing Set)
# Separate your data into training and testing portions:

from sklearn.model_selection import train_test_split

# Features: the columns that influence the target
X = df[cols]

# Target: what you want to predict
y = df['Remark'] 

# Split the data: 80% training, 20% testing

X_train, X_test, y_train, y_test = train_test_split(
    X, y, test_size=0.3, stratify=y, random_state=42
)


from sklearn.tree import DecisionTreeClassifier

# Create the model
model = DecisionTreeClassifier(random_state=42)

# Train the model
model.fit(X_train, y_train)

# Print training accuracy
train_acc = model.score(X_train, y_train)
print("Training Accuracy:", train_acc)

y_predict= model.predict(X_test)
print(y_predict)

error=y_predict - y_test
error
print(X_test)

# ----- Combined Graph: Count Plot + Confusion Matrix -----

# Create a single figure with 2 side-by-side subplots
fig, axes = plt.subplots(1, 2, figsize=(9, 4))

# =======================
#   COUNT PLOT
# =======================
sns.countplot(x='Remark', data=df, ax=axes[0], palette="Set1")

axes[0].set_title("Number of Students by Remark", fontsize=14)
axes[0].set_xlabel("Remark")
axes[0].set_ylabel("Number of Students")

for p in axes[0].patches:
    height = int(p.get_height())
    axes[0].text(
        p.get_x() + p.get_width()/2,  # x position: center of bar
        height/2,                     # y position: middle of bar
        str(height),                  # text to display
        ha='center',                  # horizontal alignment
        va='center',                  # vertical alignment
        color='white',                # text color
        fontsize=12,
        fontweight='bold'
    )
    axes[0].legend(
    title="Legend",
    labels=["Failed", "Passed"]
)

# =======================
#   CONFUSION MATRIX
# =======================
cm = confusion_matrix(y_test, y_predict)

sns.heatmap(
    cm,
    annot=True,
    fmt='d',
    cmap='Blues',
    xticklabels=['Failed', 'Passed'],
    yticklabels=['Failed', 'Passed'],
    ax=axes[1]
)

axes[1].set_title("Confusion Matrix", fontsize=14)
axes[1].set_xlabel("Predicted")
axes[1].set_ylabel("Actual")

# Adjust layout and save
plt.tight_layout()
plt.savefig("combined_graph.png")
plt.show()



# Performance Metrics

from sklearn.metrics import accuracy_score, confusion_matrix

# Predict on test set
y_pred = model.predict(X_test)

# 1. Accuracy
acc = accuracy_score(y_test, y_pred)
print("Accuracy:", acc)

cm = confusion_matrix(y_test, y_pred)
print("\nConfusion Matrix:\n", cm)




