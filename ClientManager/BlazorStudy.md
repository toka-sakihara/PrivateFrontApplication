# Blazor開発メモ


## Shared/NavMenu.razorファイル

ナビゲーションバーを定義するファイル。

- `<NavLink class="nav-link" href="accountdata">`

    ナビゲーションメニューの内容を定義。hrefにはrazorファイルの@pageで指定したリンク先を入力する。

- コード例

    ~~~code
    <div class="@NavMenuCssClass" @onclick="ToggleNavMenu">
            <li class="nav-item px-3">
                <NavLink class="nav-link" href="accountdata">
                    <span class="oi oi-list-rich" aria-hidden="true"></span>
                        アカウント情報
                </NavLink>
            </li>
        </ul>
    </div>
    ~~~

## .razorファイル

HTMLとC#の混合ファイル。

if文、foreach文など基本的なコードは@if、@foreachなどが記述できる?

- @page

    ページのパスを指定する。

- @namespace

    C#のnamespaceと同様

- @using

    C#のusingと同様

- @inject

    インスタンス作成(クラス変数的なもの？)

- @code

    C#のコード箇所

# DataGridについて

現在Microsoft公式ではGrid表示に便利なパッケージはリリースされていない(?)

# Componentとは？

画面の部品みたいなもの。

<部品名 部品で定義されているパラメーター変数名="引き渡す値"/>みたいなHTMLタグで呼び出すことができる。
