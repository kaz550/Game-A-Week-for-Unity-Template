# Game A Week for Unity Template

🎮 Unity 6 用 Game A Week テンプレートリポジトリ

このリポジトリは、
**「1週間で1本ゲームを完成させる」** ことを目的とした
Game A Week 向け Unity テンプレートです。

---

# 🚀 このテンプレートの目的

Game A Week では、

* 毎週ゲームを完成させる
* 小さく作る
* とにかく提出する
* GitHub に残す
* 短期間で実装経験を積む

ことを重視しています。

しかし毎回、

* Scene構成
* GameManager
* UI
* Audio
* Input
* シーン遷移
* フォルダ構成

などをゼロから作っていると、
本来の「ゲーム制作」に使う時間が減ってしまいます。

そこでこのテンプレートでは、

👉 **ゲーム部分の実装に集中できる状態**

を最初から用意しています。

---

# 🎯 対象

このテンプレートは以下を想定しています。

* Unity初心者〜中級者
* 専門学校授業
* Game A Week
* 個人制作
* 小規模プロトタイプ
* WebGL作品
* GitHub提出課題

---

# 🛠️ 開発環境

| 項目              | 内容               |
| --------------- | ---------------- |
| Engine          | Unity 6          |
| Render Pipeline | URP              |
| Input           | New Input System |
| Platform        | PC / WebGL       |
| Language        | C#               |

---

# 📁 フォルダ構成

```text
Assets/
├── Audio/
├── Materials/
├── Models/
├── Prefabs/
├── Scenes/
├── Scripts/
├── Sprites/
├── UI/
└── Settings/
```

---

# 🎮 シーン構成

| シーン    | 内容     |
| ------ | ------ |
| Init   | 初期化    |
| Title  | タイトル画面 |
| Game   | メインゲーム |
| Result | リザルト画面 |

---

# 🧠 基本構成

このテンプレートには以下が含まれています。

## ✅ GameManager

* シングルトン管理
* ステート管理
* シーン遷移

## ✅ UIサンプル

* タイトルUI
* リザルトUI
* ボタンイベント

## ✅ シーン遷移

```text
Title → Game → Result → Title
```

の基本フローを実装済みです。

---

# 🎧 Audio対応

* BGM再生
* SE再生
* AudioManager管理

を追加しやすい構成になっています。

---

# 🎮 Input System対応

このテンプレートは
Unity新Input Systemを前提としています。

---

# 🌐 WebGL対応

Game A Week の提出や公開を考慮し、

* WebGL Build
* itch.io公開

しやすい構成を意識しています。

---

# 📦 使用方法

## 1. このリポジトリを Clone

```bash
git clone https://github.com/kaz550/Game-A-Week-for-Unity-Template.git
```

---

## 2. Unity Hubで開く

Unity 6 で開いてください。

---

## 3. Gameシーンを改造する

基本的には：

```text
Scenes/Game
```

を改造してゲームを作ります。

---

# 🧩 推奨ルール

Game A Week では：

* 完璧を目指さない
* とにかく完成
* 小さく作る
* まず提出

を強く推奨します。

---

# 📚 おすすめ進行

## Day1

* テーマ決定
* コア実装

## Day2

* プレイヤー完成

## Day3

* 敵実装

## Day4

* UI追加

## Day5

* 演出追加

## Day6

* バランス調整

## Day7

* README作成
* GitHub提出

---

# 📝 READMEを書く文化

Game A Week では、

* なぜ作ったか
* どう実装したか
* 何を学んだか

を README に残すことを推奨しています。

コードだけではなく、

👉 「制作過程を残す」

ことも重要です。

---

# 🔥 このテンプレートの思想

このテンプレートの目的は、

👉 「綺麗な設計」

ではありません。

本当に大切なのは：

* 完成させる
* 提出する
* 毎週作る
* 実装経験を増やす

ことです。

まずは：

# 「完成」

を目指しましょう。

---

# 📄 License

MIT License

---

# 👤 Author

Kaz Take

* GitHub
  [kaz550 GitHub](https://github.com/kaz550?utm_source=chatgpt.com)

* Template Repository
  [Game A Week for Unity Template](https://github.com/kaz550/Game-A-Week-for-Unity-Template?utm_source=chatgpt.com)
