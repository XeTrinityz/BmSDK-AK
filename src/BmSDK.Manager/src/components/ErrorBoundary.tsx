import { Component, type ErrorInfo, type ReactNode } from "react";
import { Icons } from "./Icons";
import { IconTile } from "./ui";

interface State {
  error: Error | null;
}

/** Catches errors while drawing the app, so a bug shows a message and a way out in place of an empty window. */
export default class ErrorBoundary extends Component<{ children: ReactNode }, State> {
  state: State = { error: null };

  static getDerivedStateFromError(error: Error): State {
    return { error };
  }

  componentDidCatch(error: Error, info: ErrorInfo) {
    console.error("BmSDK Manager crashed while drawing:", error, info.componentStack);
  }

  render() {
    const { error } = this.state;
    if (!error) return this.props.children;

    const details = `${error.name}: ${error.message}\n${error.stack?.split("\n").slice(1, 6).join("\n") ?? ""}`;
    return (
      <div className="app-shell flex h-full items-center justify-center p-8">
        <section role="alert" className="dialog relative z-10 w-[560px]">
          <div className="flex items-center gap-3.5">
            <IconTile theme="rose" size={44} radius={14}>
              <Icons.Alert />
            </IconTile>
            <div className="min-w-0 flex-1">
              <h1 className="m-0 text-[18px] font-bold">Something went wrong</h1>
              <p className="m-0 mt-0.5 text-[12px] text-[var(--text-muted)]">
                Your mods and settings are fine. Reloading usually fixes it.
              </p>
            </div>
          </div>
          <pre className="path-box m-0 max-h-[160px] overflow-auto whitespace-pre-wrap">{details}</pre>
          <div className="flex justify-end gap-2.5">
            <button type="button" className="btn" onClick={() => void navigator.clipboard?.writeText(details)}>
              Copy details
            </button>
            <button type="button" className="btn btn-primary" onClick={() => window.location.reload()}>
              <Icons.Refresh />
              Reload
            </button>
          </div>
        </section>
      </div>
    );
  }
}
